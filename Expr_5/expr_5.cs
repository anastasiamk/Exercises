/*
 * Ulearn 1
 * Expr5. Найти количество високосных лет на отрезке [a, b] не используя циклы.
 * https://ulearn.me/course/basicprogramming/Zadachi_na_seminar_aef25d82-818b-4a50-a2f0-bba842eeeedc
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr_5
{
    class expr_5
    {
        
        static void Main(string[] args)
        {

            int a = 2000;
            a--;
            int b = 2080;

            int s = (b / 4 - b / 100 + b / 400) - (a / 4 - a / 100 + a / 400);
            Console.WriteLine(s);
        }
            
    }
}
