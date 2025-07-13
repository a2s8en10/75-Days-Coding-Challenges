using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_array
{
    class Program
    {
        static int[] sortArray(int[] num)
        {
            int temp;
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            return num;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the Length of Array : ");
            int a = int.Parse(Console.ReadLine());

            int[] num = new int[a];

            Console.Write("Enter the Element :");
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                num[i] = b;
            }

            int[] arr = sortArray(num);         // call Function sortArray
          
            Console.Write("Sort Array :");
            foreach (int item in arr)
            {
                Console.Write(" " + item);
            }

            Console.WriteLine();
            Console.Write("Reverse Array is :");
            for (int i = arr.Length-1; i>=0; i--)
            {
                Console.Write(" " + arr[i]);
            }

            Console.ReadLine();
          
        }
    }
}
