//С2. Распечатать  все целые числа из диапазона от M до N, 
//цифры которых  все четные, а сумма цифр превосходит 10.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2
{
    class c2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter m");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter n");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            int sum = 0;

            bool f = true;

            for (int i = m; i <= n; i++) // для n - m
            {
                s = i;

                for (int k = 1; s > 0; k++) // проверка на четность 
                {
                    if ((s % 10) % 2 != 0)
                    {
                        f = false;
                    }
                    else
                    {
                        sum += (s%10);
                    }
                    s /= 10;

                }
                if (f == true && sum > 10)
                {
                    Console.WriteLine(i);
                }
                sum = 0;
                f = true;
            }
        }
    }
}
