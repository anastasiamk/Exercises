/*	
 * 9. Проверить, является ли число простым	
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            double n = Convert.ToDouble(Console.ReadLine());
            double i = 2;
            bool f = true;

            while (i < Math.Sqrt(n))
            {
                if (n % i == 0)
                {
                    f = false;
                }
                i++;
            }
            if (f == true)
            {
                Console.WriteLine("prime number");

            }
            else
            {
                Console.WriteLine("compound number");
            }
        }
    }
}
