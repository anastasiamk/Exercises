/*
 * 30. Написать метод, который на вход принимает два числа, упорядочивает эти числа по возрастанию,
 * результат сохраняет в те же переменные. Параметры передавать по ссылке. Если x=39, y=25, 
 * то в результате работы методы в х должно лежать 25, в y – 39. 
 * Если x=13, y=19, то в результате работы метода в х должно лежать 13, в y -19.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_
{
    class Program
    {
        public static void Increase(ref double a, ref double b)
        {

            double pred = a;
            if (a > b)
            {
                a = b;
                b = pred;
            }
        }
        static void Main(string[] args)
        {
            double x = 39;
            double y = 25;
            Increase(ref x, ref y);
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
    }
}
