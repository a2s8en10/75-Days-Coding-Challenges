using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_string_without_using_extra_space
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Anurag sahu";
            char[] chars = str.ToCharArray();

            int n = chars.Length;
            int start = 0, end = n - 1;

            while (start < end)
            {
                char temp = chars[start];
                chars[start] = chars[end];
                chars[end] = temp;

                start++;
                end--;
            }
            Console.WriteLine(new string(chars));

            Console.ReadLine();
        }
    }
}
