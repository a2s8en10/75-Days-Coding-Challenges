using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_even_and_odd_numbers_in_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 2, 3, 34, 5, 6, 7, 7, 8 };
            int Count_Even = 0;
            int Count_Odd = 0;

            for(int i=0; i<num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Count_Even++;
                }
                else if (num[i] % 2 == 1)
                {
                    Count_Odd++;
                }
            }
            Console.WriteLine("Count Even : " + Count_Even);
            Console.WriteLine("Count Even : " + Count_Odd);

            Console.ReadLine();
        }
    }
}
