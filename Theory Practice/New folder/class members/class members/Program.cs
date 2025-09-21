using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace class_members
{
    class Program
    {
        public class Student
        {
            public Student()
            {
                Console.WriteLine("Call Contructor");
            }

            private int fees;   // field

            public int Fees // properties
            {
                get { return fees; }
                set { fees = value; }
            }

            public void CalculateAnualfees()    // Method
            {
                int anualfees = Fees + 18500;
                Console.WriteLine(anualfees);
            }

        }
        static void Main(string[] args)
        {
            Student objStudent = new Student();    // Object call 
            objStudent.Fees = 15000;
            objStudent.CalculateAnualfees();

            Console.ReadLine();
        }
    }
}
