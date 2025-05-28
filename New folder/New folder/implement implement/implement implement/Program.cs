using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_implement
{
    public class person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public void setName(string newName)
        {
            Name = newName;
        }
        public void setAge(int newAge)
        {
            Age = newAge;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person emp = new person();
            emp.setName("Anurag Sahu");
            Console.WriteLine(emp.Name);
            emp.setAge(22);
            Console.WriteLine(emp.Age);
            Console.ReadLine();

        }
    }
}
