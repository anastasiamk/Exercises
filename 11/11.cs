/*
 * 11. Вычислить 𝑦=𝑥 − (𝑥^2/2) + (𝑥^3/3)−(𝑥^4/4)+⋯+((−1)^𝑛+1 * 𝑥𝑛/𝑛)
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter n: ");
            double n = Convert.ToDouble(Console.ReadLine());

            int i = 1;
            double y = 0;

            while (i <= n)
            {
                y += ((Math.Pow((-1), i + 1)) * Math.Pow(x, i) / i);
                i++;
            }
            Console.WriteLine(y);
        }
    }
}
