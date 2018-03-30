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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\SYYEDA IZZA NAQVI\\Desktop\\data.txt");
            MessageBox.Show("Input Id to delete data");
            string SID = Console.ReadLine();
            string display = "";
            {
                string Nextline = sr.ReadLine();
                if (Nextline.Equals(SID))
                {
                    display += null;
                    display += "\n";
                    for (int j = 0; j < 5; j++)
                    {
                        display += sr.ReadLine();
                        display += "\n";
                    }
                }
                if (Nextline.Equals(null))
                {

                }
            }
            Console.WriteLine(display);
            Console.WriteLine("Data is deleted");
            SID = Console.ReadLine();
        }



        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}

     
    


