using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fill_a_jagged_array_with_user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Row : ");
            int row = int.Parse(Console.ReadLine());
            int[][] num = new int[row][];

            for (int i = 0; i < row; i++)
            {
                Console.Write($"Enter the {i + 1} row col length - ");
                int col = int.Parse(Console.ReadLine());
                num[i] = new int[col];
                Console.Write($"Enter the col value in the {i + 1} row : ");
                for (int j = 0; j < col; j++)
                {
                    int b = int.Parse(Console.ReadLine());
                    num[i][j] = b;
                }
                Console.WriteLine();
            }
            Console.WriteLine("The jagged array is : ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < num[i].Length; j++)
                {
                    Console.Write(num[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
