using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsilation_Implement
{
    public class person
    {
        public string name { get; private set; }
        public int age { get; private set; }

        public void setAge (int newAge)
        {
            age = newAge;
        }
        public void setName (string newName)
        {
            name = newName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person obj = new person();
            obj.setName("Anurag sahu");
            obj.setAge(24);
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.age); 
            Console.ReadLine();
        }
    }
}
