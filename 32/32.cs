//32. Написать рекурсивный метод, который находит сумму цифр числа.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    class Program
    {
        public static int Summa(int k)
        {
            if (k < 10)
            {
                return k;
            }
            else
            {
                return (k%10) + Summa(k/10);
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Summa(355));
        }
    }
}
