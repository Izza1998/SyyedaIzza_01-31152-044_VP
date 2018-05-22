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
    public partial class Repot : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;uid=root;" + "database=votingsystem;");
        public Repot()
        {
            InitializeComponent();
        }

        private void Repot_Load(object sender, EventArgs e)
        {
            fillChart1();
            fillChart2();
            fillChart3();

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void fillChart1()
        {
            string can1 = "";
            string can2 = "";
            string can3 = "";
            string Vcan1 = "";
            string Vcan2 = "";
            string Vcan3 = "";
            MySqlCommand Comm1 = new MySqlCommand("SELECT * FROM poll WHERE city='Islamabad'", conn);
            try
            {
                
                conn.Open();
                using (MySqlDataReader read = Comm1.ExecuteReader())
                {
                    while (read.Read())
                    {
                        can1= (read["Candidate1"].ToString());
                        can2= (read["Candidate2"].ToString());
                        can3 = (read["Candidate3"].ToString());
                    }
                }
            }
            finally
            {
                conn.Close();
            }
            MySqlCommand Comm2 = new MySqlCommand("SELECT * FROM votes WHERE ID=1", conn);
            try
            {

                conn.Open();
                using (MySqlDataReader read = Comm2.ExecuteReader())
                {
                    while (read.Read())
                    {
                        Vcan1 = (read["Candidate1"].ToString());
                        Vcan2 = (read["Candidate2"].ToString());
                        Vcan3 = (read["Candidate3"].ToString());
                    }
                }
            }
            finally
            {
                conn.Close();
            }


            chart1.Series["Islamabad"].Points.AddXY(can1, Vcan1);
            chart1.Series["Islamabad"].Points.AddXY(can2, Vcan2);
            chart1.Series["Islamabad"].Points.AddXY(can3, Vcan3); 
            chart1.Titles.Add("Islamabad Voting Results");
            

        }
        private void fillChart2()
        {
            string can1 = "";
            string can2 = "";
            string can3 = "";
            string Vcan1 = "";
            string Vcan2 = "";
            string Vcan3 = "";
            MySqlCommand Comm1 = new MySqlCommand("SELECT * FROM poll WHERE city='Karachi'", conn);
            try
            {

                conn.Open();
                using (MySqlDataReader read = Comm1.ExecuteReader())
                {
                    while (read.Read())
                    {
                        can1 = (read["Candidate1"].ToString());
                        can2 = (read["Candidate2"].ToString());
                        can3 = (read["Candidate3"].ToString());
                    }
                }
            }
            finally
            {
                conn.Close();
            }
            MySqlCommand Comm2 = new MySqlCommand("SELECT * FROM votes WHERE ID=2", conn);
            try
            {

                conn.Open();
                using (MySqlDataReader read = Comm2.ExecuteReader())
                {
                    while (read.Read())
                    {
                        Vcan1 = (read["Candidate1"].ToString());
                        Vcan2 = (read["Candidate2"].ToString());
                        Vcan3 = (read["Candidate3"].ToString());
                    }
                }
            }
            finally
            {
                conn.Close();
            }


            chart2.Series["Karachi"].Points.AddXY(can1, Vcan1);
            chart2.Series["Karachi"].Points.AddXY(can2, Vcan2);
            chart2.Series["Karachi"].Points.AddXY(can3, Vcan3);
            chart2.Titles.Add("Karachi Voting Results");


        }
        private void fillChart3()
        {
            string can1 = "";
            string can2 = "";
            string can3 = "";
            string Vcan1 = "";
            string Vcan2 = "";
            string Vcan3 = "";
            MySqlCommand Comm1 = new MySqlCommand("SELECT * FROM poll WHERE city='Lahore'", conn);
            try
            {

                conn.Open();
                using (MySqlDataReader read = Comm1.ExecuteReader())
                {
                    while (read.Read())
                    {
                        can1 = (read["Candidate1"].ToString());
                        can2 = (read["Candidate2"].ToString());
                        can3 = (read["Candidate3"].ToString());
                    }
                }
            }
            finally
            {
                conn.Close();
            }
            MySqlCommand Comm2 = new MySqlCommand("SELECT * FROM votes WHERE ID=3", conn);
            try
            {

                conn.Open();
                using (MySqlDataReader read = Comm2.ExecuteReader())
                {
                    while (read.Read())
                    {
                        Vcan1 = (read["Candidate1"].ToString());
                        Vcan2 = (read["Candidate2"].ToString());
                        Vcan3 = (read["Candidate3"].ToString());
                    }
                }
            }
            finally
            {
                conn.Close();
            }


            chart3.Series["Lahore"].Points.AddXY(can1, Vcan1);
            chart3.Series["Lahore"].Points.AddXY(can2, Vcan2);
            chart3.Series["Lahore"].Points.AddXY(can3, Vcan3);
            chart3.Titles.Add("Lahore Voting Results");
        } 
    }
}
