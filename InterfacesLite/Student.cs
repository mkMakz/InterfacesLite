using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLite
{
    public class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get ; set; }
        public int[] Grades { get; set; }
        

        private Random r = new Random();

        public Student(string name, string fullname)
        {
            Name = name;
            FullName = fullname;
            Grades = new int[r.Next(1, 10)];

            for (int i = 0; i < Grades.Length; i++)
            {
                Grades[i] = r.Next(1, 6);
            }
        }

        public string GetName()
        {
            return Name;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public double GetAvgGrade()
        {
            int cnt = 0;
            for (int i = 0; i < Grades.Length; i++)
            {
                cnt += Grades[i];
            }
            return (double)(cnt / Grades.Length);
        }

        public void PrintInfo()
        {

            Console.WriteLine($"Name {GetName()}\n FullName {GetFullName()}\n Average Grade {GetAvgGrade()} ");

        }

    }
}
