/*
 * 1.При заданном х вычислить значение функции {−𝑥,𝑥≤0,
 *                                          y = 𝑥^2,0<𝑥≤2,
 *                                              4,𝑥>2.}
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 0;

            if (x <= 0)
            {
                y = -x;
            }
            else if ((x > 0) && (x <= 2))
            {
                y = x * x;

            }
            else if (x > 2)
            {
                y = 4;
            }

            Console.WriteLine("y = {0}", y);
        }
    }
}
