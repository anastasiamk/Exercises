/*
 * Даны два числа, необходимо найти и вывести максимальное
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumb
{
    class maxnumb
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Max number:{0}", Math.Max(number1, number2));
        }
    }
}
