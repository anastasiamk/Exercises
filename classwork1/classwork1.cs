// (Σ i=1; n;)   ( x^(2i-1) ) / ( 4^i * (2i +1)! )
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork1
{
    class classwork1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter n: ");
            double n = Convert.ToDouble(Console.ReadLine());

            double s = 0;

            int i = 2;
            double f = 2 * 3;
            double dr = x / (4 * f);
            double s1 = dr;

            do
            {
                s = s1;
                dr *= ((x * x) / (4 * (i * 2) * (i * 2 + 1)));
                s1 = s + dr;
                i++;
            }
            while (i <= n);
            {
                Console.WriteLine(s1);
            }
        }
    }
}
