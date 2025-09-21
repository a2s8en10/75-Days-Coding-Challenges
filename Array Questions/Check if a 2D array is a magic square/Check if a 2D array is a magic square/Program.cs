using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_2D_array_is_a_magic_square
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = new int[3, 3]
            {
                { 8, 1, 6 },
                { 3, 5, 7 },
                { 4, 9, 2 }
            };

            bool flag = true;
            int sum = 0;


            for (int i = 0; i < num.GetLength(0); i++)
            {
                sum += num[0, i];
            }

            // Check 2D array is square
            if (num.GetLength(0) == num.GetLength(1))
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            // check rows and columns
            if (flag)
            {
                for (int i = 0; i < num.GetLength(0); i++)
                {
                    int row = 0, col = 0;
                    for (int j = 0; j < num.GetLength(1); j++)
                    {
                        row += num[i, j];
                        col += num[j, i];
                    }
                    if (sum != row || sum != col)
                    {
                        flag = false;
                        break;
                    }
                }
            }

            //check columns
            //if (flag)
            //{
            //    for (int i = 0; i < num.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < num.GetLength(1); j++)
            //        {
            //            col += num[j, i];
            //        }
            //        if (sum != col)
            //        {
            //            flag = false;
            //            break;
            //        }
            //    }
            //}

            // check diagonals
            if (flag)
            {
                int dia1 = 0;
                for (int i = 0; i < num.GetLength(0); i++)
                {
                    dia1 += num[i, i];
                }
                if (sum != dia1)
                {
                    flag = false;
                }
            }

            if (flag)
            {
                int dia2 = 0;
                for (int i = 0; i < num.GetLength(0); i++)
                {
                    dia2 += num[i, num.GetLength(1) - i - 1];
                }

                if (sum != dia2)
                {
                    flag = false;
                }
            }

            if (flag)
            {
                Console.WriteLine("The 2D array is a magic square.");
            }
            else
            {
                Console.WriteLine("The 2D array is not a magic square.");
            }

            Console.ReadLine();
        }
    }
}
