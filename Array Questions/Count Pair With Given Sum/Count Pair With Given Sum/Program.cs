using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Count_Pair_With_Given_Sum
{
    class Program
    {
        static int Count(int[]num, int sum)
        {
            int i, j;
            int count = 0;

            for (i = 0; i < num.Length-1; i++)
            {
                for (j = i+1; j < num.Length; j++)
                {
                    if (sum == num[i] + num[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] num = { 1, 1, 3, 2, 2 };
            int sum = 2;
            int arr = Count(num,sum);

            Console.Write("Given Array : ");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(" "+num[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Given Sum : "+ sum);

            Console.WriteLine("Count Pair with Given Sum : "+ arr);
            Console.ReadLine();
        }
    }
}
