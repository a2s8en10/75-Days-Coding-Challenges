using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_subarray_with_the_given_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 23, 4, 54, 6, 3 };
            int target = 64;
            int sum = 0, count = 0,start=0,end=0;
            bool flag = false;

            for(int i =0; i < num.Length; i++)
            {
                sum = sum + num[i];
                if(sum > target)
                {
                    i = count;
                    count++;
                    sum = 0;
                }
                
                if(sum == target)
                {
                    start = count;
                    end = i + 1;
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Your target does not exist in any subarray!");
            }
            else
            {
                Console.Write("Your target is exsit in subarray : ");

                for (int i = start; i < end; i++)
                {
                    Console.Write(num[i] + " ");
                    //Console.WriteLine(num[i]);
                }
            }

            Console.ReadLine();

        }
    }
}
