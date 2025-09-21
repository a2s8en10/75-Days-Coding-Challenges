using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral_print_of_a_matrix__2D_array_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = new int[4, 4] {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            int row = 0, col = 0;
            int rowend = num.GetLength(0) - 1;
            int colend = num.GetLength(1) - 1;

            while (row <= rowend && col <= colend)
            {
                for (int i = col; i <= colend; i++)
                {
                    Console.WriteLine(num[row, i]);
                }
                row++;

                for (int i = row; i <= rowend; i++)
                {
                    Console.WriteLine(num[i, colend]);
                }
                colend--;

                for (int i = colend; i >= col; i--)
                {
                    Console.WriteLine(num[rowend, i]);
                }
                rowend--;

                for (int i = rowend; i >= row; i--)
                {
                    Console.WriteLine(num[i, col]);
                }
                col++;
            }
            Console.ReadLine();
        }
    }
}
