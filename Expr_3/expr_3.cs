/*
 * Ulearn 1
 * Expr3. Задано время Н часов (ровно). Вычислить угол в градусах между часовой и минутной стрелками. 
 * Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов. Не использовать циклы.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr_3
{
    class expr_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time: ");
            string time = Console.ReadLine();
            switch (time)
            {
                case "1":
                    Console.WriteLine("30 degrees");
                    break;
                case "2":
                    Console.WriteLine("60 degrees");
                    break;
                case "3":
                    Console.WriteLine("90 degrees");
                    break;
                case "4":
                    Console.WriteLine("120 degrees");
                    break;
                case "5":
                    Console.WriteLine("150 degrees");
                    break;
                case "6":
                    Console.WriteLine("180 degrees");
                    break;
                case "7":
                    Console.WriteLine("150 degrees");
                    break;
                case "8":
                    Console.WriteLine("120 degrees");
                    break;
                case "9":
                    Console.WriteLine("90 degrees");
                    break;
                case "10":
                    Console.WriteLine("60 degrees");
                    break;
                case "11":
                    Console.WriteLine("30 degrees");
                    break;
                case "0":
                    Console.WriteLine("0 degrees");
                    break;

            }
        }
    }
}
