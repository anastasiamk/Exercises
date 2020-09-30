/*
 * 19. Вычислить значение функции y=|x-2|+|x+1|, для x в отрезке [-4;4], с шагом 0.5.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            for(double i = -4; i<=4; i+=0.5)
            {
                double y = Math.Abs(i - 2) + Math.Abs(i + 1);
                Console.WriteLine("x = {0}, y = {1}", i, y);
            }
        }
    }
}
