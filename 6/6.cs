/*
 * 6. Вычислить сумму 𝑦 = 1 + 𝑥 + (𝑥^2/2!) + (𝑥^3/3!) +...+ (𝑥^𝑛/𝑛!)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            double n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            int i = 1;
            double f = 1;
            double y = 1;

            while(i <= n)
            {
                f *= i;
                y += Math.Pow(x, i) / f;
                i++;
            }
            Console.WriteLine(y);
        }
    }
}
