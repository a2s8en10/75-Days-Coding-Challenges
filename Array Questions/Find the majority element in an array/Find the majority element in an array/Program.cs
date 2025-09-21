using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_majority_element_in_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[7] { 2, 4, 5, 3, 2, 2, 2 };
            bool flag = false;

            int m = num.Length / 2;

            for (int i = 0; i < num.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] == num[j])
                        count++;
                }
                if (count > m)
                {
                    Console.WriteLine("Majority element is: " + num[i]);
                    flag = true;
                    break;
                }
            }
            if(!flag)
            {
                Console.WriteLine("Majority element is not find !");
            }

            Console.ReadLine();
        }
    }
}
