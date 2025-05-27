using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Implement
{
    abstract class Person
    {
        public abstract void Detail();
        public void Show()
        {
            Console.WriteLine("Show Detail....");
        }
    }
    class Student : Person
    {
        public override void Detail()
        {
            Console.WriteLine("Student is here..");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person student = new Student();
            student.Detail();
            student.Show();

            Console.ReadLine();
        }
    }
}
