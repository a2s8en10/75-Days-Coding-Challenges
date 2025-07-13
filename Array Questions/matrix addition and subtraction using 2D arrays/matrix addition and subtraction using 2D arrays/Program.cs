
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_addition_and_subtraction_using_2D_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num1 = new int[3, 4]
            {
                { 11, -12, 13, 0 },
                { 21, 22, -23, 24 },
                { 0, -32, 33, -34 },
            };

            int[,] num2 = new int[3, 4]
            {
                { -1, -2, -3, 6 },
                { 21, -22, 23, 24 },
                { 31, 32, 0, -34 },
            };

            int i = 0;

            //Console.WriteLine("Given Array is First Matrix - ");
            //for (i = 0; i < num1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < num1.GetLength(1); j++)
            //    {
            //        Console.Write(num1[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //Console.WriteLine("Given Array is second Matrix - ");
            //for (i = 0; i < num2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < num2.GetLength(1); j++)
            //    {
            //        Console.Write(num2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            int[,] arrAdd = new int[num1.GetLength(0), num1.GetLength(1)];
            int[,] arrSub = new int[num1.GetLength(0), num1.GetLength(1)];

            while (i < num1.GetLength(0) && i < num2.GetLength(0))
            {
                int j = 0;
                while (j < num1.GetLength(1) && j < num2.GetLength(1))
                {
                    arrAdd[i, j] = num1[i, j] + num2[i, j];
                    arrSub[i, j] = num1[i, j] - num2[i, j];
                    j++;
                }
                i++;
            }

            Console.WriteLine("Addition of Using 2D Array - ");
            for (i = 0; i < arrAdd.GetLength(0); i++)
            {
                for (int j = 0; j < arrAdd.GetLength(1); j++)
                {
                    Console.Write(arrAdd[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Subtraction of Using 2D Array - ");
            for (i = 0; i < arrSub.GetLength(0); i++)
            {
                for (int j = 0; j < arrSub.GetLength(1); j++)
                {
                    Console.Write(arrSub[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
