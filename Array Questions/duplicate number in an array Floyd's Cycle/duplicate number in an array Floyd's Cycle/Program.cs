using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicate_number_in_an_array_Floyd_s_Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 4, 2, 2 };

            int slow = nums[0];
            int fast = nums[0];

            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            } while (slow != fast);

            slow = nums[0];
            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }

            Console.WriteLine("Duplicate number is: " + slow);

            Console.ReadLine();
        }
    }
}
