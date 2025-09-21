using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_row_with_the_maximum_sum_in_a_2D_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = new int[3, 3]
            {
                { 2, 5, 9 },
                { 9, 8, 2 },
                { 1, 5, 9 }
            };
            int nextSum = 0;
            int largeValue = 0;

            for (int i = 0; i < num.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    sum += num[i, j];
                }
                if (sum > nextSum)
                {
                    largeValue = sum;
                }
                nextSum = sum;
            }
            Console.WriteLine("The largest sum of the rows is: " + largeValue);
            Console.ReadLine();



        }
    }
}
