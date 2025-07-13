using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_two_sorted_arrays
{
    class Program
    {
        static int[] merged(int[] num1, int[] num2)
        {
            int TotalLength = num1.Length + num2.Length;
            int[] arr = new int[TotalLength];

            int count = 0, i = 0, j = 0;

            while (i < num1.Length && j < num2.Length)
            {
                if (num1[i] <= num2[j])
                {
                    arr[count++] = num1[i++];
                }
                else
                {
                    arr[count++] = num2[j++];
                }
            }

            while (i < num1.Length)
            {
                arr[count++] = num1[i++];
            }

            while (j < num2.Length)
            {
                arr[count++] = num2[j++];
            }

            return arr;

        }
        static void Main(string[] args)
        {
            int[] num1 = new int[5] { 1, 4, 5, 8, 9 };
            int[] num2 = new int[5] { 2, 3, 6, 7, 10 };
           
            int[] num = merged(num1, num2);

            Console.Write("Merge Array : ");
            foreach (int a in num)
            {
                Console.Write(" " + a);
            }

            Console.ReadLine();
        }
    }
}
