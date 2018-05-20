using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLite
{
    class Program
    {
        static void Main(string[] args)
        {

            Student st = new Student("Maxim", "Maxim Ostroukhov");
            st.GetName();
            st.GetFullName();
            st.GetAvgGrade();
            Console.WriteLine("\n");
            st.PrintInfo();


        }
    }
}
