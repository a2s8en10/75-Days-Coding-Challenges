using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_equilibrium_index_of_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[4] { -1, 2, 1, 1};
            int rightSum = 0, leftSum = 0;
            bool flag = false;
            for (int i = 1; i < num.Length; i++)
            {
                rightSum = 0;
                leftSum = 0;
                for (int j = i + 1; j < num.Length; j++)
                {
                    rightSum = rightSum + num[j];
                }
                for (int k = i - 1; k >= 0; k--)
                {
                    leftSum = leftSum + num[k];
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine("Index {0} is the equilibrium index.", i);
                    flag = true;
                    break;
                }
                //else
                //{
                //    rightSum = 0;
                //    leftSum = 0;
                //}
            }
            if (!flag)
            {
                Console.WriteLine(" No equilibrium index here");
            }


            //int totalSum = 0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    totalSum = totalSum + num[i];
            //}

            //for (int i = 0; i < num.Length; i++)
            //{
            //    rightSum = totalSum - num[i] - leftSum;

            //    if (leftSum == rightSum)
            //    {
            //        Console.WriteLine("Index {0} is the equilibrium index.", i);
            //        flag = true;
            //        break;
            //    }
            //    leftSum += num[i];

            //}
            //if (!flag)
            //{
            //    Console.WriteLine(" No equilibrium index here");
            //}

            Console.ReadLine();
        }
    }
}
