using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_array_without_using_built_in_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 12, 23, 4242, 324, 31 };

            Console.Write("Given Array is : ");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(" " + num[i]);
            }

            Console.WriteLine();

            Console.Write("Reverse Array is : ");
            for (int i = num.Length-1 ; i >= 0; i--)
            {
                Console.Write(" " + num[i]);
            }
            Console.ReadLine();
        }
    }
}
