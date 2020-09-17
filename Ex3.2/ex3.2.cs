/*
 * Упражнение 3.2 Создать структуру данных, которая хранит информацию
 * о банковском счете – его номер, тип и баланс. Создать переменную такого типа,
 * заполнить структуру значениями и напечатать результат.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3._2
{
    class Program
    {
        public enum BankType { current, savings }
        public struct BankAccount
        {
            public double balance;
            public string nomber;
            public BankType banktype;
        }
        static void Main(string[] args)
        {
            BankAccount tinkoff;
            tinkoff.balance = 2100;
            tinkoff.nomber = "012536";
            tinkoff.banktype = BankType.current ;
            Console.WriteLine("Bank account nomber is: {0}, balanse = {1}, type: {2}", tinkoff.nomber, tinkoff.balance, tinkoff.banktype);
        }
    }
}
