//25. Написать метод для вычисления n

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    class Program
    {
        public static int Factorial(int a)
        {
            int res = 1;
            for (int i = 1; i <= a; i++)
            {
                res *= i;
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }
    }
}
