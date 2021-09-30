using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace Report_in_excel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "John Smith", Age = 12, Grade = 7 });
            students.Add(new Student { Name = "Ellie Mueller", Age = 14, Grade = 5 });
            students.Add(new Student { Name = "Anne Lee", Age = 15, Grade = 9 });

            foreach (var s in students)
            {
                Console.WriteLine((" " + s.Name + "\t"));
                Console.WriteLine((" Age: " + s.Age + "\t"));
                Console.WriteLine(" Final grade: " + s.Grade + "\t \n");
            }
            int[] grades = { 7, 5, 9 };
            int sum = grades.Sum();
            Console.WriteLine(" The total of the grades: " + sum);

            //Report for each student

            StringBuilder csvcontent = new StringBuilder();
            csvcontent.AppendLine(", Report, ");
            csvcontent.AppendLine("Students, Age, Grade");
            csvcontent.AppendLine("Anne Lee, 15, 9");
            csvcontent.AppendLine("Ellie Mueller, 14, 5");
            csvcontent.AppendLine("John Smith, 12, 7");
            csvcontent.AppendLine(", , ");
            csvcontent.AppendLine("The total of the grades, , " + sum);

            string pathSchoolReport = @"C:\Users\User\OneDrive\Documents\Report in excel\School_report.csv";
            File.AppendAllText(pathSchoolReport, csvcontent.ToString());
        }
    }
}
