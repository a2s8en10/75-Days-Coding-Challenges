using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_average_of_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 4324234, 42332, 232, 245, 24230 };
            int[] arr = new int[5] { 21, 42, 53, 4, 6 };

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("Sum of All Element : {0}",sum);
            int avg = sum / arr.Length;
            Console.WriteLine("Average of Element : {0}",avg);

            Console.ReadLine();
        }
    }
}
