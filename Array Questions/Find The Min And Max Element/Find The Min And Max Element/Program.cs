using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_The_Min_And_Max_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Length of Array : ");
            int a = int.Parse(Console.ReadLine());
            int[] num = new int[a];

            Console.Write("Enter the Array Element : ");
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                num[i]= b;
            }

            int temp = 0;

            for (int i = 0; i < a-1; i++)
            {
                for (int j = i+1; j < a; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            Console.Write("Sort array is : ");
            foreach (int i in num)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.Write("Given array is : ");
            foreach (int item in num)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine("Max Value in Array : " + num[a-1]);
            Console.WriteLine("Min Value in Array : " + num[0]);



            Console.ReadLine();
        }
    }
}
