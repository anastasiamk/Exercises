/*
 * 23.Для введенного n приблизительно нарисовать символами круг радиуcа n.
 *   Не использовать строки и массивы символов. Например, для n = 10:
 *   
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inter radius")
            int r = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 2 * r; i++)
            {
                for (int j = 0; j <= 2 * r; j++)
                {

                    if ((i - r) * (i - r) + (j - r) * (j - r) <= r * r)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
