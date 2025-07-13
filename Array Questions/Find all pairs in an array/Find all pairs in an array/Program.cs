using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_all_pairs_in_an_array
{
    class Program
    {
        static int[] PairsFind(int[] arr , int a)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == a)
                    {
                        Console.WriteLine("pairs : ({0},{1})", arr[i], arr[j]);
                    }
                }
            }

            return arr;
        }
        static void Main(string[] args)
        {
            int[] num = new int[5] { 1, 3, 2, 2, 3};
            int sum = 4;

            PairsFind(num, sum);

            //for (int i = 0; i < num.Length; i++)
            //{
            //    for (int j = i+1; j < num.Length; j++)
            //    {
            //        if (num[i] + num[j] == sum)
            //        {
            //            Console.WriteLine("pairs : ({0},{1})", num[i], num[j]);
            //        }
            //    }
            //}

            Console.ReadLine();
        }
    }
}
