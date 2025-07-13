using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_diagonal_elements_in_a_2D_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = new int[3, 3]
            {
                { 1, 2, 3,},
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int Sum = 0;
            Console.WriteLine("Given Array is : ");
            for (int i = 0;i<num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Sum = Sum + num[i, j];
                    }
                    Console.Write(num[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Sum of Digonal Elements : {0}",Sum);
            Console.ReadLine();
        }
    }
}
