using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_all_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 123, 412, 534, 35, 52 };
            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum = sum + num[i];
            }
            Console.WriteLine("Sum of all element - {0} ", sum);

            Console.ReadLine();

        }
    }
}
