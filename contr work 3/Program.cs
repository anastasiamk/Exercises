using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contr_work_3
{
    class Program
    {
        static void Obrabotka(string ms)
        {
            Console.WriteLine(ms);       }
        static void Obrabotka2(string ms)
        {
            Console.Beep();
        }

        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "A" };
            Person p2 = new Person() { Name = "B" };
            
            BankAccount b1 = new BankAccount(2356, p1);
            BankAccount b2 = new BankAccount(10, p2);

            b1.AlarmEven += Obrabotka;

            b1.Put(10);
            b1.Take(20);
           

            
        }
    }
}
