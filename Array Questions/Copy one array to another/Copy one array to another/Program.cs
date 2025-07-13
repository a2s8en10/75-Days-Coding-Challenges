using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_one_array_to_another
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 5, 8, 2, 7, 2, 5, 35 };
            int[] copyNum = new int[num.Length];

            Console.Write("Num Array :");
            for (int i = 0; i < num.Length; i++)
            {
                copyNum[i] = num[i];
                Console.Write(" " + num[i]);

            }
            Console.WriteLine();
            Console.Write("Copy Num Array :");
            for (int i = 0; i < copyNum.Length; i++)
            {
                Console.Write(" " + copyNum[i]);
            }

            Console.ReadLine();
        }
    }
}
