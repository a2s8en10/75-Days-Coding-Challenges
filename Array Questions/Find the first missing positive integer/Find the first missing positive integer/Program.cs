using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_first_missing_positive_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[6] { 2, -3, 4, 1, 1, 7 };

            int count = 1;
            int missingValue = 0;
            bool flag = false;

            // short the array in ascending order
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = 0; j < num.Length - i - 1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        int temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] <= 0)
                    continue;

                if (i > 0 && num[i] == num[i - 1])
                    continue;

                if (count != num[i])
                {
                    missingValue = count;
                    flag = true;
                    break;
                }
                else
                {
                    count++;
                }
            }
            if (flag)
            {
                Console.Write("The First Missing Positive Value : " + missingValue);
            }
            else
            {
                int value = num[num.Length - 1] + 1;
                Console.Write("The First Missing Positive Value : " + value);
            }
            Console.ReadLine();
        }
    }
}
