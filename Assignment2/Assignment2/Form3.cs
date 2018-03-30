using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Assignment2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\SYYEDA IZZA NAQVI\\Desktop\\data.txt");
            MessageBox.Show("Input ID to search");
            string SID = textBox1.Text.ToString();
            string display = "";
            for (int i = 0; sr.Peek() >= 0; i++)
            {
                string Nextline = sr.ReadLine();
                if (Nextline.Equals(SID))
                {
                    display += Nextline;
                    display += "\n";
                    for (int j = 0; j < 5; j++)
                    {
                        display += sr.ReadLine();
                        display += "\n";
                    }
                }
                if (Nextline.Equals(null))
                {
                    break;
                }
            }
            MessageBox.Show(display);
        }
    }
}
