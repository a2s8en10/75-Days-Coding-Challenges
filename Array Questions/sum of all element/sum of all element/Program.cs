using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_all_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 1,2,3,4,54};
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum = num[i] + sum;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
