using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transpose_a_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = new int[3, 4]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
            };

            Console.WriteLine("Given a Matrix : ");
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.Write(num[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Transpose a Matrix : ");
            for (int j = 0; j < num.GetLength(1); j++)
            {
                for (int i = 0; i < num.GetLength(0); i++)
                {
                    Console.Write(num[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
