using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    class Program
    {
        public static double Nod(double x1, double x2)
        {
            double res = 1;

            for (double i = 1; i <= Math.Min(x1, x2); i++)
            {
                if ((x1 % i == 0) && (x2 % i == 0) && (i >= res))
                {
                    res = i;
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine(Nod(4, 8));
            Console.WriteLine(Nod(Nod(2, 6), 8));
        }
    }
}
