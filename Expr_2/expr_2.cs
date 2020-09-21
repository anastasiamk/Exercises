/* 
 * Ulearn 1
 * Expr2. Задается натуральное трехзначное число (гарантируется, что трехзначное).
 * Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr_2
{
    class expr_2
    {
        static void Main(string[] args)
        {
        //что за задача? не помню
        
            string a = Console.ReadLine();
            char[] array = a.ToCharArray();

            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }
    }
}
