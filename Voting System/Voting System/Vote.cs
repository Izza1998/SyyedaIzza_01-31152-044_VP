using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Voting_System
{
    public partial class Vote : Form
    {
        public Vote()
        {
            InitializeComponent();
        }

        private void Vote_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'votingsystemDataSet.poll' table. You can move, or remove it, as needed.
            this.pollTableAdapter.Fill(this.votingsystemDataSet.poll);

        }
    }
}
