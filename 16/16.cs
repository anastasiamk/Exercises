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
<<<<<<< HEAD
                    if (i % 2 != 0)
                    {
                        Console.Write("* ");
                    }
                    else
                    {

                        Console.Write(" *");
                    }
=======
                //В каждой строке должно быть N звездочек. 
                //Каждая четная строка сдвинута на один пробел правее нечетной.
                    Console.Write("* * * *   *");
                }
                else
                {
                    Console.Write(" * * *   * *");
>>>>>>> cb636a467303bc8e9546a7c529c2d1f26753d11d
                }
                Console.WriteLine();
            }
        }
    }
}
