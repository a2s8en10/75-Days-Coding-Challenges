using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_all_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 213, 4, 5, 212, 5 };

            Console.WriteLine("Using Foreach Loop");
            foreach(int i in num)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("Using For Loop");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            Console.ReadLine();
               
        }
    }
}
