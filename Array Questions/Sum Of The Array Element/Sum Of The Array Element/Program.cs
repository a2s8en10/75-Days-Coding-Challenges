using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_The_Array_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array length : ");
            int a = int.Parse(Console.ReadLine());
            int[] num = new int[a];

            Console.Write("Enter the array Element : ");
            for (int i = 0; i<a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                num[i] = b;
            }

            int sum = 0;

            foreach (int i in num)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum Of All Array Element : " + sum);

            Console.ReadLine();

        }
    }
}
