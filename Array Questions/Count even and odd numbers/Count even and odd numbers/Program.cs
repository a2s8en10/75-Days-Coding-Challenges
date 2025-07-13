using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_even_and_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 2313, 53, 42, 1425, 1242 };

            int Even_Count = 0;
            int Odd_Count = 0;


            for (int i = 0; i < num.Length; i++)
            {
                int temp = num[i] % 2;

                if(temp == 0)
                {
                    Even_Count++;
                }
                if(temp == 1)
                {
                    Odd_Count++;
                }
            }

            Console.WriteLine("Event element is : {0}",Even_Count);
            Console.WriteLine("Odd element is : {0}",Odd_Count);

            Console.ReadLine();
        }
    }
}
