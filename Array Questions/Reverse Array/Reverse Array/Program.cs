using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lenght of array : ");
            int a = int.Parse(Console.ReadLine());
            int[] num = new int[a];

            Console.Write("Enter the Array : ");
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                num[i] = b;
            }

            Console.Write("Reverse array is : ");
            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.Write(num[i] + " ");
            }

            Console.ReadLine();

        }
    }
}
