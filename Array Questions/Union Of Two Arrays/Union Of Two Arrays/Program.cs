using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union_Of_Two_Arrays
{
    class Program
    {
        static int[] union(int[] arr1, int[]arr2)
        {
            int length = arr1.Length + arr2.Length;
            int[] arr = new int[length];

            int k = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                arr[k] = arr1[i];
                k++;
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                arr[k] = arr2[i];
                k++;
            }

            //for (int i = 0; i < arr.Length-1; i++)
            //{
            //    for (int j = i+1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            //continue;
            //            int indexToRemove = arr[j]; Console.WriteLine("f");
            //        }
            //    }
            //}

            return arr;





        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 4, 5, 6, 7 };

            int[] arr = union(arr1, arr2);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();


        }
    }
}
