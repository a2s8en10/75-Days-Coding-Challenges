using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specific_element_exists_in_the_array_or_not
{
    class Program
    {
        static int[] exists(int[] arr)
        {
            Console.Write("Enter The Specific Element : ");
            int num = int.Parse(Console.ReadLine());
            Boolean temp = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (num == arr[i])
                {
                    temp = true;
                }
            }
            if (temp)
            {
                Console.WriteLine("Specific Element is Exists : {0}",num);
            }
            else
            {
                Console.WriteLine("Specific Element is not Exists : {0}", num);
            }

            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 7, 3, 5 };

            int[] b = exists(arr);

            Console.ReadLine();
            
        }
    }
}
