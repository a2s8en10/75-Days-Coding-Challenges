using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_Kadane_s_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 5, 0, -6, 4, 2 };
            int sum = 0, maxSum = 0, count = 0, flag = 0,s=0;

            for (int i = 0; i < num.Length; i++)
            {
               if(sum + num[i] < num[i])
                {
                    sum = num[i];
                    count = i;
                }
               else
                {
                    sum = sum + num[i];
                }
               if(maxSum < sum)
                {
                    maxSum = sum;
                    flag = i + 1;
                    s = count;
                }
            }
            Console.WriteLine("Maximum Sum : "+maxSum);
            Console.Write("Subarray is : ");
            for(int i = s; i < flag; i++)
            {
                Console.Write(num[i] + " ");

            }
            Console.ReadLine();
        }
    }
}
