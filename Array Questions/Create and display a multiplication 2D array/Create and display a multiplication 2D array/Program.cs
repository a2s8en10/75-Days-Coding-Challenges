using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_and_display_a_multiplication_2D_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the table no. - ");
            int n = int.Parse(Console.ReadLine());
            int[,] num = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    num[i,j] = j+1;
                }
            }
           
            Console.WriteLine("Multiplication in 2D array : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}", i + 1);
                //Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write($" {num[i, j]}x{num[i, i]}");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
