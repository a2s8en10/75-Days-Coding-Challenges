using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_all_the_leaders_in_the_array_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 5, 2, 4, -6, 2 };
            int[] arr = new int[num.Length];
            int lead = 0, count = 0;

            for (int i = num.Length-1; i >= 0; i--)
            {
                //lead = num[i];
                if(lead < num[i])
                {
                    lead = num[i];
                    arr[count] = lead;
                    count++;
                }
            }
            Console.Write("Leader in the array :");

            for (int i = count - 1; i >= 0; i--)
            {
                Console.Write(" " + arr[i]);
            }
            
            Console.ReadLine();
        }
    }
}
