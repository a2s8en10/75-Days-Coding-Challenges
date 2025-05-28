using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_implement
{
    public class poly
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public string Add(string a, string b)
        {
            return a + b;
        }
    }
    class Program
    {   
        static void Main(string[] args)
        {
            poly obj = new poly();
            int num = obj.Add(12, 38);
            string str = obj.Add("Anurag", "Sahu");
            Console.WriteLine(num + " - " + str);
            Console.ReadLine();
        }
    }
}
