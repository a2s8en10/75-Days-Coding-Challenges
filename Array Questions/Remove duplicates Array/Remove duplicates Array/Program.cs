using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_duplicates_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 24, 24, 12, 5, 12 };
            int[] arr = new int[num.Length];
            int count = 0;

            for (int i = 0; i < num.Length; i++)
            {
                int temp = 0;

                for (int j = 0; j < count; j++)
                {
                    if (num[i] == num[j])
                    {
                        break;
                    }
                    temp++;

                }
                if(temp == count)
                {
                    arr[count] = num[i];
                    count++;
                }

            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }
    }
}
