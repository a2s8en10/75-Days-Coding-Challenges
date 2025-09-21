using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_elements_of_a_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] num = new int[3][]{
               new int[] { 112,43,5467,4,646,46,4},
               new int[] { 352,35,53,53,256,35},
               new int[] { 4,6,99,78,789},
            };

            for (int i = 0; i < num.GetLength(0); i++)
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
