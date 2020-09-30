//14. Вычислить ln(1+ 𝑥) ≈ 𝑥 − 𝑥^2/2 +𝑥^3/3 − 𝑥^4/4 +⋯+ ( (−1)^(𝑛+1)𝑥^𝑛 )/𝑛 +⋯ с точностью 1e-9

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
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

            do
            {
                s = s1;
                s1 = s + (ch / zn);
                ch = ch * (-1) *x;
                zn += 1; 
            }
            while (Math.Abs(s1-s) > eps);
            {
                Console.WriteLine(s1);
                Console.WriteLine(Math.Log(1 + x));
            }
            
        }
    }
}
