using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_maximum_and_minimum_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 13, 32, 3, 41, 1 };

            int min = num[0];
            int max = num[0];


            for (int i = 0; i<num.Length; i++)
            {
                if (num[i] < min)
                    min = num[i];

                if (num[i] > max)
                    max = num[i];
            }
            Console.Write("Array is :");
            foreach (int i in num)
            {
                Console.Write(" " + i);
            }

            Console.WriteLine();
            Console.WriteLine("Minimum value : " + min);
            Console.WriteLine("Maximum value : " + max);

            Console.ReadLine();
        }
    }
}
