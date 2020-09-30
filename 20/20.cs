/*
 * 20. Распечатать таблицу Пифагора (таблица умножения)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<= 9;i++)
            {
                for (int k = 1; k<= 9; k++)
                {
                    Console.Write("{0}\t ", (i*k));
                }
                Console.WriteLine();
            }
        }
    }
}
