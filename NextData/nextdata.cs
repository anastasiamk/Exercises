/*
 * Дана корректная дата в виде трех целых чисел. Получить дату следующего дня.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextData
{
    class nextdata
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current data: ");
            DateTime time_1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(time_1);
            Console.WriteLine(time_1.AddDays(1));
        }
    }
}
