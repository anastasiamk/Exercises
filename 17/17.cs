//17. Вывести все простые числа в диапазоне от 1 до N. N вводится пользователем.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                bool f = true;
                for (int k = 2; k <= Math.Sqrt(n); k++)
                {
                    if ((i%k == 0) && (i != k))
                    {
                        f = false;
                    }
                }
                if (f == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
