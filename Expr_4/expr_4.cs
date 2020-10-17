/*
 * Ulearn 1
 * Expr4. Найти количество чисел меньших N, которые имеют простые делители X или Y.
 * https://ulearn.me/course/basicprogramming/Zadachi_na_seminar_aef25d82-818b-4a50-a2f0-bba842eeeedc
 * 
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr_4
{
    class expr_4
    {
        public static int Prost(int x, int n)
        {
            return (n - 1) / x;
        }
        static void Main(string[] args)
        {
            Console.Write("enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("enter y: ");
            int y = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Prost(x, n) + Prost(y, n) - Prost(x * y, n));
        }
    }
}
