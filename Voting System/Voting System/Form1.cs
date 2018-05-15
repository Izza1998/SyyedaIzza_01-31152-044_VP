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
    public partial class Form1 : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;uid=root;" + "database=votingsystem;");
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("Select * from employee where Username like'" + textBox1.Text + "'and password like '" + textBox2.Text + "'", conn);
            conn.Open();
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                this.Hide();
                HomeScreen Form = new HomeScreen(textBox1.Text);
                Form.Show();
                conn.Close();

            }
            else
            {
                MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                var login = new Form1();
                login.Show();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
