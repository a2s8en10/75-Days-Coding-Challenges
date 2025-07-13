using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 24, 8484, 8785, 5489, 548 };

            for (int i = 0; i < num.Length - 1; i++)
            {
                for(int j = i + 1; j < num.Length ; j++)
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
            foreach(int i in num)
            {
                Console.Write(" " + i);
            }

            Console.ReadLine();

        }
    }
}
