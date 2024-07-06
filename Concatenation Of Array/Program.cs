using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenation_Of_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Length of Array :");
            int n = int.Parse(Console.ReadLine());

            int[]nums = new int[n];

            Console.Write("Enter the Element: ");
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                nums[i] = a;
            }

            int n2 = n * 2;
            int[] ans = new int[n2];
            for (int i = 0;i < n; i++)
            {
                ans[i] = nums[i];
                ans[i + n] = nums[i];
            }
            Console.WriteLine("Array ans......");
            foreach (int i in ans)
                Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
