using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declare_and_initialize_a_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] num  // Declaration 
            //= new int[3][] // Partial Initialization
            //{  Initialization
            //    new int[] { 12, 30, 44, 64, 74, 76, 63, 98, 19 },      
            //   new int[] { 25, 36, 47, 58, 69 },
            //   new int[] { 98, 55, 52 }
            //}

            
            int[][] num = new int[3][]
            {
               new int[] {12,30,44,64,74,76,63,98,19},     // Initialization 
               new int[] {25,36,47,58,69 },
               new int[] {98,55,52}
            };
        }
    }
}
