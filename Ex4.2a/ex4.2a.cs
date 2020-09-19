/*
 * 2.Задана точка своими двумя координатами. Принадлежит ли точка заштрихованной области
 * a)
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (( (x * x) + (y*y -2*y + 1) <= 1 ) && (y + x*x <= 1) )
            {
                Console.WriteLine("Point belongs to the shaded area");
            }
            else
            {
                Console.WriteLine("Point does not belongs to the shaded area");
            }
        }
    }
}
