﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = {1,2,3,4,5,6,7};

            for (int i=0; i<num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadLine();
        }
    }
}
