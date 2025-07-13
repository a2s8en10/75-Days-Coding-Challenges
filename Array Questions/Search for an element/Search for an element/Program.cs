using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_for_an_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 21, 3, 23, 342, 434 };

            Console.Write("Enter the Search Element : ");
            int a = int.Parse(Console.ReadLine());

            bool temp = false;

            for(int i = 0; i < num.Length; i++)
            {
                if(a == num[i])
                {
                    temp = true;
                }
            }
            if (temp == true)
            {
                Console.WriteLine("Search Element is Exist : {0}",a);
            }
            else
            {
                Console.WriteLine("Search Element is not Exist : {0}", a);
            }
            Console.ReadLine();
        }
    }
}
