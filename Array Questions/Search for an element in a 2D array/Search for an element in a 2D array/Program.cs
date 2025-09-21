using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_for_an_element_in_a_2D_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = new int[4, 4]
            {
                {11,12,13,14},
                {15,16,17,18},
                {19,20,21,22},
                {23,24,25,26}
            };

            int target = 23;
            bool found = false;

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = num.GetLength(1) - 1; j >= 0; j--)
                {
                    if (target == num[i, j])
                    {
                        Console.WriteLine("Element found at row {0}, column {1}", i, j);
                        found = true;
                        break;
                    }
                    else if (target > num[i, j])
                    {
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("Element {0} found in the 2D array.", target);
            }
            else
            {
                Console.WriteLine("Element {0} not found in the 2D array.", target);
            }

            Console.ReadLine();
        }
    }
}
