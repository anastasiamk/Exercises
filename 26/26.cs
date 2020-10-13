//26. Написать метод вычисления n-го числа ряда Фибоначчи.
//Ряд Фибоначчи 1, 1, 2, 3, 5, 8, 13, 21, … Формула вычисления n-го числа Fn=Fn-1+Fn-2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    class Program
    {
        public static int Fibonacci(int x)
        {
            int pred = 0;
            int posl = 1;
            int res = 0;
            int i = 2;
            while(i <= x)
            {
                res = pred + posl;
                pred = posl;
                posl = res;
                i++;
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(9));
        }
    }
}
