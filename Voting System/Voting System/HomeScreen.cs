using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Voting_System
{
    public partial class HomeScreen : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;uid=root;" + "database=votingsystem;");
        public HomeScreen()
        {
            InitializeComponent();
        }
        public HomeScreen(string username)
        {
            InitializeComponent();
            MySqlCommand Comm1 = new MySqlCommand("SELECT * FROM employee WHERE Username like '" + username + "'", conn);
            try
            {
                conn.Open();
                using (MySqlDataReader read = Comm1.ExecuteReader())
                {
                    while (read.Read())
                    {
                        label4.Text = (read["Name"].ToString());
                        label5.Text = (read["designation"].ToString());
                        label6.Text = (read["city"].ToString());
                    }
                }
            }
            finally
            {
                conn.Close();
            }
        }
        private void HomeScreen_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            label7.Text = today.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vote v = new Vote();
            v.Show();
        }
    }
}
