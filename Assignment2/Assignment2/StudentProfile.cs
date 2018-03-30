using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Assignment2
{
    class StudentProfile
    {
        public void StdProfileInfo(string name1, string std_ID, string University, string Dept1, string sem, float gpa)
        {

            StreamWriter sw = File.AppendText("C:\\Users\\SYYEDA IZZA NAQVI\\Desktop\\data.txt");
            sw.AutoFlush = true;
            sw.WriteLine(name1);
            sw.WriteLine(std_ID);
            sw.WriteLine(University);
            sw.WriteLine(Dept1);
            sw.WriteLine(sem);
            sw.WriteLine(gpa);
            sw.Close();
            MessageBox.Show("The profile has been created successfully");
            
            
        }
    }
}
