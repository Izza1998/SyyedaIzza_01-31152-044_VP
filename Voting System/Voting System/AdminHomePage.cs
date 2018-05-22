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
    public partial class AdminHomePage : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;uid=root;" + "database=votingsystem;");
       
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {
        }
        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Show();
        }

        private void seeResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Repot rt = new Repot();
            rt.Show();
        }

        private void deletePollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Poll rt = new Delete_Poll();
            rt.Show();
        }

        private void createPollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatePoll rt = new CreatePoll();
            rt.Show();
        }
    }
}
