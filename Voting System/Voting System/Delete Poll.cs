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
    public partial class Delete_Poll : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;uid=root;" + "database=votingsystem;");
        public Delete_Poll()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                int ID = 0;
                if (comboBox1.Text == "Islamabad")
                {
                    ID = 1;
                }
               if(comboBox1.Text=="Karachi")
               {
                   ID = 2;
               }
               if (comboBox1.Text == "Lahore")
               {
                   ID = 3;
               }
               try
                {
                    MySqlCommand cmd = new MySqlCommand("Update poll Set position = 'Null', Candidate1= 'Null', Candidate2 = 'Null', Candidate3='Null' Where ID = " + ID + "", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MySqlCommand cmd1 = new MySqlCommand("Update votes Set Candidate1=0, Candidate2 = 0, Candidate3=0 Where ID = " + ID + "", conn);
                    cmd1.ExecuteNonQuery();
                    MySqlCommand cmd2 = new MySqlCommand("Update employee set status = 'No' where city = '" + comboBox1.Text + "'", conn);
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Poll Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
 
                }
            }
            else
            {
                MessageBox.Show("Please Select a City", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Poll_Load(object sender, EventArgs e)
        {

        }
    }
}
