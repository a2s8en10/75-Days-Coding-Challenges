using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_an_array_contains
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 12, 4343, 4334, 3443, 43 };

            Console.Write("Enter Value Check Array Element contain : ");
            int a = int.Parse(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < num.Length; i++)
            {
                if (a == num[i])
                {
                    found = true;
                }
            }
            if (found)
            {
                Console.WriteLine("Array Element is Contain : {0} ",a);
            }
            else
            {
                Console.WriteLine("Array Element is not Contain : {0} ", a);
            }
            Console.ReadLine();
        }
    }
}
