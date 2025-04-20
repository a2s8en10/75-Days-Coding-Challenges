using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Find_The_Missing_Number
{
    class Program
    {
        static int MissingNumber(int[] num,int a)
        {
            int sum = 0;

            foreach (int i in num)
            {
                sum += i;
            }

            int total = a * (a + 1) / 2;
            int n = total - sum;
            return n;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter The Array Length : ");
            int a = int.Parse(Console.ReadLine());
            int[] num = new int[a];
            Console.Write("Enter The Missing Array Element : ");
            for (int i = 0; i < a-1; i++)
            {
                int b = int.Parse(Console.ReadLine());
                num[i] = b;
            }

            int miss = MissingNumber(num, a);
            Console.Write("Missing Array Element is : " + miss);

            Console.ReadLine();
        }
    }
}
