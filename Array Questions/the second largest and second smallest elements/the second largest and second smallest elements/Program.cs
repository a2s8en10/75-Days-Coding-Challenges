using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_second_largest_and_second_smallest_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 546, 46544, 444, 5484, 9852100 };

            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        int temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }

            Console.Write("Sort Array is :");
            foreach (int i in num)
            {
                Console.Write(" " + i);
            }

            Console.WriteLine();

            for(int i = 0; i< num.Length; i++)
            {
                if(i == 1)
                {
                    Console.WriteLine("Second Smallest Element is : {0} ", num[i]);
                }
                else if (i == num.Length - 2)
                {
                    Console.WriteLine("Second Largest Element is : {0} ", num[i]);

                }
            }
            Console.ReadLine();
        }
    }
}
