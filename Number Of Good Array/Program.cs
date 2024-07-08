using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Of_Good_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, };
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length-1; j++)
                {
                    if (i < j)
                    {
                        if (nums[i] == nums[j])
                        {
                            count++;
                        }
                    }
                }
            }
            if (count != 0)
            {
                Console.WriteLine("Good pair...");
            }
            else
            {
                Console.WriteLine("it is not Good pair");
            }
            Console.ReadLine();
        }
    }
}
