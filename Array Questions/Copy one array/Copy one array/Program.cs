using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_one_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 123, 24, 424, 14324, 325 };

            int[] arr = new int[num.Length];

            for(int i = 0; i < num.Length; i++)
            {
                arr[i] = num[i];
            }

            Console.Write("num Array is : ");
            foreach(int i in num)
            {
                Console.Write(" " + i);
            }

            Console.WriteLine();

            Console.Write("arr Array is : ");
            foreach (int a in arr)
            {
                Console.Write(" " + a);
            }

            Console.ReadLine();
        }
    }
}
