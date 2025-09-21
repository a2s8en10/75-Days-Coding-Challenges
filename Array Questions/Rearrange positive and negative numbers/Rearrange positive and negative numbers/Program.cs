using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Rearrange_positive_and_negative_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 1, 2, 3, 6, -5 };
            int[] arr = new int[num.Length];
            List<int> postive = new List<int>();
            List<int> negative = new List<int>();

            int pos = 0, neg = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < 0)
                {
                    negative[neg] = num[i];
                    neg++;
                }
                else
                {
                    postive[pos] = num[i];
                    pos++;
                }
            }
            int m = 0, n = 0, count = 0;
            bool flag = true;

            while (m < pos && n< neg)
            {
                if (flag)
                    arr[count++] = postive[m++];
                else
                    arr[count++] = negative[n++];

                flag = !flag;
            }

            while (m < pos)
                arr[count++] = postive[m++];

            while (n < neg)
                arr[count++] = negative[n++];

            Console.Write("Rearranged array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
