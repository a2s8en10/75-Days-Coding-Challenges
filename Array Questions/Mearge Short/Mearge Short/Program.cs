using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mearge_Short
{
    class Program
    {
        static int[] Merge(int[] num1, int[] num2)
        {
            int length = num1.Length + num2.Length;
            int[] num = new int[length];
            int i = 0, j = 0, k = 0;

            while(i<num1.Length && j < num2.Length)
            {
                if (num1[i] < num2[j])
                {
                    num[k] = num1[i];
                    i++;
                    k++;
                }
                else
                {
                    num[k] = num2[j];
                    j++;
                    k++;
                }
            }
            while (i < num1.Length)
            {
                num[k] = num1[i];
                i++;
                k++;
            }
            while(j < num2.Length)
            {
                num[k] = num2[j];
                j++;
                k++;
            }

            return num;
        }
        static void Main(string[] args)
        {
            int[] num1 = { 1, 2, 3, 4, 5};
            int[] num2 = { 6, 7, 8, 9, 10 };

            int[] num = Merge(num1, num2);

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadLine();
        }
    }
}
