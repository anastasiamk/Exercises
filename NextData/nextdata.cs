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
            Console.WriteLine("Enter day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year: ");
            string year = Console.ReadLine();


            if ((Convert.ToInt32(year) % 4 == 0) && (month == 2)) // год високосный + февраль
            {
                if (day == 28) //конец месяца
                    {
                        Console.WriteLine("29.02.{0}", year);
                    }
                    else //не конец
                    {
                        Console.WriteLine("{0}.02.{1}", day + 1, year);
                    }
                    
            }

            //дальше вся для обычных

            else if (month == 1 || month == 3 || month == 5 || month == 7|| month == 8 || month == 10) // месяца, в которых 31 день(кроме декабря)
            {
                if (day == 31) //конец месяца
                {
                    Console.WriteLine("01.{0}.{1}", month+1, year);
                }
                else //не конец
                {
                    Console.WriteLine("{0}.{1}.{2}", day + 1, month, year);
                }
            }



            else if (month == 4 || month == 6 || month == 9 || month == 11) //месяца, в которых 30 дней
            {
                if (day == 30) //конец
                {
                    Console.WriteLine("01.{0}.{1}", month + 1, year);
                }
                else //не конец
                {
                    Console.WriteLine("{0}.{1}.{2}", day + 1, month, year);
                }
            }


            else if (month == 12) //для декабря
            {
                if (day == 31) //нг
                {
                    Console.WriteLine("01.01.{0}", year+1);
                    Console.WriteLine("Happy New Year!");
                }
                else
                {
                    Console.WriteLine("{0}.12.{1}", day + 1, year);
                }
            }


            else if (month == 2) //февраль невисокосный
            {
                if (day == 28)
                {
                    Console.WriteLine("1.03.{0}", year);
                }
            }





        }
    }
}
