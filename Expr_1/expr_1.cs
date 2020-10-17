/* 
 * Ulearn 1
 * Expr1. Как поменять местами значения двух переменных?
 * Можно ли это сделать без ещё одной временной переменной.
 * 
 * https://ulearn.me/course/basicprogramming/Zadachi_na_seminar_aef25d82-818b-4a50-a2f0-bba842eeeedc
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr_1
{
    class expr_1
    {
        static void Main(string[] args)
        {
            double a = 2;
            double b = 3;

            //через произведение
            //a = a * b / (b = a);

            //через сумму
            a = a + b - (b = a);

            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
