using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SP_assignment
{
    class Student
    {
        private string name, ID, Uni, Dept, semester;
        private float cgpa;
        public void StudentProfile(string name1, string std_ID, string University, string Dept1, string sem, float gpa,string pathOfFile)
    {
        name = name1;
        ID = std_ID;
        Uni = University;
        Dept = Dept1;
        semester = sem;
        cgpa = gpa;
        StreamWriter sw = File.AppendText("C:\\Users\\SYYEDA IZZA NAQVI\\Desktop\\data.txt");
        sw.AutoFlush = true;
        sw.WriteLine(name);
        sw.WriteLine(ID);
        sw.WriteLine(Uni);
        sw.WriteLine(Dept);
        sw.WriteLine(semester);
        sw.WriteLine(cgpa);
        sw.Close();
        Console.WriteLine("Data has been sucessfully saved");
    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
             string name="", ID="", Uni="", Dept="", semester="";
             float cgpa=0.0f;
            string Nextline="",SID="",display="";
            string delete="";
            int selection=1;
             Student obj = new Student();
             StreamReader reader = new StreamReader("C:\\Users\\SYYEDA IZZA NAQVI\\Desktop\\data.txt");
             string data = reader.ReadToEnd();
             reader.Close();
             Console.Write("Enter your choice");
             selection = Convert.ToInt16(Console.ReadLine());
             if (selection == 1)
             {
                 //create profile code starts here
                 Console.WriteLine("Enter student ID: ");
                 while (true)
                 {
                     ID = Console.ReadLine();

                     if (data.Contains(ID))
                     {
                         Console.WriteLine("Id exists, try again: ");
                     }
                     else
                         break;
                 }
                 Console.WriteLine("Enter the Name: ");
                 name = Console.ReadLine();

                 
                 Console.WriteLine("Enter name of Uni: ");
                 Uni = Console.ReadLine();
                 Console.WriteLine("Enter name of Dept: ");
                 Dept = Console.ReadLine();
                 Console.WriteLine("Enter semester no: ");
                 semester = Console.ReadLine();
                 Console.WriteLine("Enter name of cgpa: ");
                 cgpa = float.Parse(Console.ReadLine());

                 obj.StudentProfile(name, ID, Uni, Dept, semester, cgpa, args[0]);
                 

             }
             if (selection == 2)
             {
                 StreamReader sr = new StreamReader("C:\\Users\\SYYEDA IZZA NAQVI\\Desktop\\data.txt");
                 Console.WriteLine("Input ID to search");
                 SID = Console.ReadLine();
                 for (int i = 0; sr.Peek()>=0; i++) 
                 {
                     Nextline=sr.ReadLine();
                     if(Nextline.Equals(SID))
                     {
                         display+= Nextline;
                         display += "\n";
                         for(int j=0; j<5; j++)
                         {
                             display+= sr.ReadLine();
                             display+="\n";
                         }
                     }
                     if (Nextline.Equals(null))
                     {
                         break;
                     }
                 }
                 Console.WriteLine(display);
             }
             if (selection == 3)
             {
                 StreamReader sr = new StreamReader("C:\\Users\\SYYEDA IZZA NAQVI\\Desktop\\data.txt");
                 Console.WriteLine("Input Id to delete data");
                 SID = Console.ReadLine();
                
                 {
                     Nextline = sr.ReadLine();
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
                 Console.WriteLine(delete);
                 Console.WriteLine("Data is deleted");
                 SID = Console.ReadLine();
             }
               Console.ReadKey();
             }       
        
    }
}
