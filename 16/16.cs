/* 16. Дано число N. Напечатать N строк вида

**** … *

*** …. **

**** … *

*** …. **
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //n строк ввода
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= n; k++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write("* ");
                    }
                    else
                    {

                        Console.Write(" *");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
