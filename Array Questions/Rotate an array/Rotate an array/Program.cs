using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_an_array
{
    class Program
    {
        //static int[] leftSide(int[]arr , int a)
        //{
        //    int[] num = new int[arr.Length];


        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        num[i] = arr[(i + a) % arr.Length];
        //    }

        //    return num;
        //}

        //static int[] rightSide(int[]arr , int a)
        //{
        //    int[] num = new int[arr.Length];

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        num[(i + a) % arr.Length] = arr[i];
        //    }

        //    return num;
        //}
        static void Main(string[] args)
        {
            int[] num = new int[5] { 12, 52, 525, 253, 520 };

            int n = num.Length;
            int r = 3;

            Console.Write("Given Array : ");
            for (int i = 0; i <  num.Length; i++)
            {
                Console.Write(" " + num[i]);
            }
            Console.WriteLine();

            //  LEFT ROTATION
            int[] left = new int[n];
            for (int i = 0; i < n; i++)
            {
                left[i] = num[(i + r) % n];
            }

            Console.Write("Left : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + left[i]);
            }

            //  RIGHT ROTATION
            int[] right = new int[n];
            for (int i = 0; i < n; i++)
            {
                right[(i + r) % n] = num[i];
            }
            Console.WriteLine();

            Console.Write("Right : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + right[i]);
            }


            //int[] left = leftSide(num, 2);
            //int[] right = rightSide(num, 2);

            //Console.WriteLine("Left: " + string.Join(", ", left));
            //Console.WriteLine("Right: " + string.Join(", ", right));


            Console.ReadLine();

        }
    }
}
