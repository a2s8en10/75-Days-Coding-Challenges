using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_maximum_and_minimum_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 13, 32, 3, 41, 1 };
            int temp = 0;
            for (int i = 0; i < num.Length-1; i++)
            {
                //for (int j = i+1;  j< num.Length; j++)
                //{
                    if (num[i] < num[i+1])
                    {
                        temp = num[i];
                        num[i] = num[i+1];
                        //num[i+1] = temp;
                    }
                //}
            }
                Console.WriteLine(temp);

            Console.ReadLine();
        }
    }
}
