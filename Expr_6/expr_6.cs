/*
 * Ulearn 1
 * Expr6. Посчитать расстояние от точки до прямой, заданной двумя разными точками.
 * https://ulearn.me/course/basicprogramming/Zadachi_na_seminar_aef25d82-818b-4a50-a2f0-bba842eeeedc
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter point coordinate: ");
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the coordinates of the first point of the line: ");
            Console.Write("x1 = ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the coordinates of the second point of the line: ");
            Console.Write("x2 = ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            int y2 = int.Parse(Console.ReadLine());

            double s = Math.Abs((y2 - y1) * x - (x2 - x1) * y + x2 * y1 - y2 * x1) / Math.Sqrt(((y2 - y1) * (y2 - y1)) + ((x2 - x1) * (x2 - x1)));
            Console.WriteLine(s);
        }
    }
}
