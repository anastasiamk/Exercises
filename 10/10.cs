/*
 * 10. Дано 6-значное целое число – номер билета. 
 * Проверить, является ли он счастливым. Билет счастливый, 
 * если сумма первых трех цифр числа совпадает с суммой вторых трех цифр.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a six-digit number");
            string s = Console.ReadLine();
            int sum1;
            int sum2;
            sum1 = (int)s[0] + (int)s[1] + (int)s[2];
            sum2 = (int)s[3] + (int)s[4] + (int)s[5];

            if (sum1 == sum2)
            {
                Console.WriteLine("lucky ticket");
            }
            else
            {
                Console.WriteLine("unlucky ticket");
            }
        }
    }
}
