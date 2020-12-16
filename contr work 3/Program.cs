using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contr_work_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "A" };
            Person p2 = new Person() { Name = "B" };
            //  Console.WriteLine(p1);
            BankAccount b1 = new BankAccount(2356, p1);
            BankAccount b2 = new BankAccount(10, p2);
            //   Console.WriteLine(b1.Numchet);
            b1.Put(10);
            b1.PrintList();
            // Console.WriteLine(b1.Balans);
            //b1.Transaction(b2, 10);
            //Console.WriteLine(b1);
            //Console.WriteLine(b2);
            //Console.WriteLine(b1 == b2);
            //b1.Print();
        }
    }
}
