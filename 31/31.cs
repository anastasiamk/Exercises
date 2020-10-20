//31. Написать рекурсивный метод для вычисления n-го числа ряда Фибоначчи
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    class Program
    {
        public static int Fibonacci(int x)
        {
            if ((x == 0) || (x == 1))
            {
                return 1;
            }
            else
            {
                return Fibonacci(x - 1) + Fibonacci(x - 2);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(5));
        }
    }
}
