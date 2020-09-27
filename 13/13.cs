/*
 * 13. Задано число n в k-ичной системе счисления (2<k<9). 
 * Сконвертировать n в десятичную систему счисления. 
 * Строковые типы не используются.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            string s = Console.ReadLine(); //для длины строки
            int n = int.Parse(s);

            Console.WriteLine("Enter CC: ");
            int cc = int.Parse(Console.ReadLine());

            double r = 0; 
            int mnoz = 10; //для получения цифры по разряду

            for(int i = 1; i <= s.Length; i++)
            {
                int ost = n % mnoz; //получаем цифру

                r += ost * Math.Pow(cc, i-1);
                n /= 10;

            }
            Console.WriteLine(r);
        }
    }
}
