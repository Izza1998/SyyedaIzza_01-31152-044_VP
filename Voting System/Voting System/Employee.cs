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
    public partial class Employee : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;uid=root;" + "database=votingsystem;");
       
        public Employee()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT into employee (Username,Name,password,designation,city,status) values ('" + textBox2.Text + "','" + textBox1.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "','No');", conn);
                    conn.Open();
                    conn.Close();
                    MessageBox.Show("Data Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Please Insert Correct information in all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {
                MessageBox.Show("Please Insert Correct information in all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
