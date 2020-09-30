//15. Вычислить 𝑐𝑜𝑠 𝑥≈ ∑∞𝑖=0  ( (−1)^𝑖 * 𝑥^2𝑖 ) / (2𝑖)!  с точностью 1e-9.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double s = 0;
            double s1 = 0;
            double eps = 0.000000001;
            double ch = x;
            double zn = 1;
            int i = 0;
            do
            {
                s = s1;
                s1 = s + (ch / zn);
                ch = ch * (-1) * x * x;
                i++;
                zn *= i;
                i++;
                zn *= i;
            }
            while (Math.Abs(s1 - s) > eps);
            {
                Console.WriteLine(s1);
                Console.WriteLine(Math.Cos(x));
            }
        }
    }
}
