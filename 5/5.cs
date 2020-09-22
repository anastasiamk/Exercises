/*
 * 5. Вычислить произведение 𝑃=(1−1/2)(1−1/3)...(1−1/𝑛)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            double n = Convert.ToInt32(Console.ReadLine());
            double i = 2;
            double p = 1;
            while (i <= n)
            {
                p *= (1 - (1.0 / i));
                i++;
            }
            Console.WriteLine("p = {0}", p);

        }
    }
}
