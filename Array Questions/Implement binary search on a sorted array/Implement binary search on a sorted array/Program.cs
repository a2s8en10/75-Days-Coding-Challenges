using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Implement_binary_search_on_a_sorted_array
{
    class Program
    {
        static int Search(int[] arr, int a)
        //static bool Search(int[] arr, int a)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == a)
                {
                    //Console.WriteLine($"Element found at index: {arr[mid]}");
                    //return true;
                    return mid;
                }

                else if (arr[mid] < a)
                    low = mid + 1;

                else
                    high = mid - 1;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] num = new int[9] { 12, 34, 45, 51, 67, 76, 81, 93, 104 };
            int target = 34;
           
            //bool binary = Search(num, target);
            int binary = Search(num, target);
            if (binary != -1)
            //if (binary != false)
                {
                Console.WriteLine("Element found at index: {0}",binary);
            }
            else
            {
                Console.WriteLine($"Element not found");
            }

                Console.ReadLine();

        }
    }
}
