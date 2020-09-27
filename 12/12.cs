/*
 * 12. Дано число, проверить что в числе все цифры идут по убыванию.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num:");
            string s = Console.ReadLine();
            bool f = true;

            for (int i = 0; i <= (int)s.Length - 1; i++)
            {
                if ((int)s[i] <= (int)s[i + 1])
                {
                    Console.WriteLine(s[i]);
                    f = false;
                }
            }
            if (f == false)
            {
                Console.WriteLine("not try");
            }
            else
            {
                Console.WriteLine("try");
            }
        }
    }
}
