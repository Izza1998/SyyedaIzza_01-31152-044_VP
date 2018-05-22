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
    public partial class CreatePoll : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;uid=root;" + "database=votingsystem;");
        public CreatePoll()
        {
            InitializeComponent();
        }

        private void CreatePoll_Load(object sender, EventArgs e)
        {

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
                if (comboBox1.Text == "Karachi")
                {
                    ID = 2;
                }
                if (comboBox1.Text == "Lahore")
                {
                    ID = 3;
                }
                if (comboBox2.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("Update poll Set position = '" + comboBox2.Text + "', Candidate1= '" + textBox1.Text + "', Candidate2 = '" + textBox2.Text + "', Candidate3='" + textBox3.Text + "' Where ID = " + ID + "", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MySqlCommand cmd1 = new MySqlCommand("Update votes Set Candidate1=0, Candidate2 = 0, Candidate3=0 Where ID = " + ID + "", conn);
                        cmd1.ExecuteNonQuery();
                        MySqlCommand cmd2 = new MySqlCommand("Update employee set status = 'No' where city = '" + comboBox1.Text + "'", conn);
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Poll Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Please Insert Correct information in all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Please Insert Correct information in all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Select a City", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
