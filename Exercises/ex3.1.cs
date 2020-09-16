/*
 * Упражнение 3.1 Создать перечислимый тип данных отображающий
 * виды банковского счета (текущий и сберегательный). Создать переменную типа
 * перечисления, присвоить ей значение и вывести это значение на печать
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        enum BankAccount { current, savings }
        static void Main(string[] args)
        {
            BankAccount account_1 = (BankAccount)0;
            Console.WriteLine(account_1);
        }
    }
}
