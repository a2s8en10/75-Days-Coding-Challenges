using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum_and_minimum_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 424, 43, 535, 253, 2525 };

            int min = num[0];
            int max = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
                if (num[i] > max)
                {
                    max = num[i];
                }
            }

            Console.WriteLine("maximum array is : {0}",max);
            Console.WriteLine("minimum array is : {0}",min);

            Console.ReadLine();

        }
    }
}
