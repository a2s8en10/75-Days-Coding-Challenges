using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_two_matrices_using_jagged_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] num1 = new int[3][]
            {
                new int[]{5,9,10,12,19},
                new int[]{7,19,12},
                new int[]{2,3,7,8,1}
            };

            int[][] num2 = new int[3][]
            {
                new int[]{5,9,10,12,19},
                new int[]{7,19,12},
                new int[]{2,3,7,8,1}
            };

            //int[][] num = new int[3][];
            List<List<int>> num = new List<List<int>>(); // outer 

            for (int i = 0; i < num1.Length; i++)
            {
                //num[i] = new int[num1[i].Length];     // use the length of the first matrix with Array using
                List<int> r = new List<int>();       // use the length of the first matrix with List & inner 
                for (int j = 0; j < num1[i].Length; j++)
                {
                    //num[i][j] = num1[i][j] + num2[i][j]; // using Array
                    r.Add(num1[i][j] + num2[i][j]);
                }

                num.Add(r);
            }

            Console.WriteLine("The sum of the two matrices is: ");
            for (int i = 0; i < num.Count; i++)
            {
                for (int j = 0; j < num[i].Count; j++)
                {
                    Console.Write(num[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
