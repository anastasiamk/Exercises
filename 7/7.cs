/*
 * 7. Вычислить произведение 𝑃=(𝑥+1!)(𝑥^2+2!)...(𝑥^𝑛+𝑛!)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 1;
            int i = 1;
            double f = 1;

            Console.WriteLine("Enter n: ");
            double n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            while(i <= n)
            {
                f *= i;
                p *= (Math.Pow(x, i) + f);
                i++;
            }
            Console.WriteLine(p);

        }
    }
}
