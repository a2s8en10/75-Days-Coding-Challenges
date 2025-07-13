using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average_of_numbers_in_the_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 34, 45, 6, 7 };
            int sum = 0;

            for(int i = 0; i<num.Length; i++)
            {
                sum = sum + num[i];
            }

            Console.Write("Array Element is :");
            foreach (int item in num)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Console.Write("Number of Element is :" + num.Length);

            Console.WriteLine();
            int average = sum / num.Length;
            Console.Write("Average of number in the array : " + average);

            Console.ReadLine();
        }
    }
}
