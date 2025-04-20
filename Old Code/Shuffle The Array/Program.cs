using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle_The_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Array");
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            int[] ans = new int[n];
            int n2 = n / 2;
           
            Console.Write("Enter the element");
            for (int k = 0; k < n; k++)
            {
                int d = int.Parse(Console.ReadLine());
                num[k] = d;
            }
            int i = 0 , j = 0;
            while(j < n2)
            {
                ans[i] = num[j];
                ans[i + 1] = num[j + n2];
                i = i + 2;
                j = j + 1;
            }

            Console.Write("Shuffle The Array.......");

            foreach (int a in ans)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
