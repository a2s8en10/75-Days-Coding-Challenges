using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flatten_a_jagged_array_to_a_single_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] num = new int[3][]
            {
                new int[] {2,5,7,9,8,10},
                new int[] {1,3,9,15,17},
                new int[] {4,6,12},
            };
            List<int> Array = new List<int>();

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for(int j = 0; j < num[i].Length; j++)
                {
                    Array.Add(num[i][j]);
                }
            }

            Console.Write("Flatten a jagged array are convert the single (1D)array : ");

            foreach(int i in Array)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
