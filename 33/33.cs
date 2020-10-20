//33. Написать рекурсивный метод возведения числа в целую неотрицательную степень.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    class Program
    {
        public static int Power(int n, int k)
        {
            if (k == 0)
            {
                return 1;
            }
            else if(k == 1)
            {
                return n;
            }
            else
            {
                return n * Power(n, (k-1));
            }
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine(Power(6, 0));
        }
    }
}
