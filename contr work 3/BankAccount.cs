using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contr_work_3
{
    class BankAccount : IPrint
    {
        private int numchet;
        private double balans;
        private Person vladelec;
        static int cnt = 0;
        private List<DateTime> l = new List<DateTime>(20);
        //
        public void PrintList()
        {
            foreach (DateTime s in l)
                Console.WriteLine(s);
        }
        public DateTime this[int index]
        {
            get
            {
                return l[index];
            }
            
        }
        //свойства
        public int Numchet
        {
            get
            {
                return numchet;
            }
        }
        public double Balans
        {
            get
            {
                return balans;
            }
        }
        public Person Vladelec
        {
            get
            {
                return vladelec;
            }
        }

        //конструкторы
        public BankAccount()
        {

            balans = 0;
            vladelec = new Person();
        }
        //public BankAccount(int numch)
        //{
        //    numchet = numch;
        //}
        public BankAccount(double bal)
        {
            balans = bal;
        }
        public BankAccount(double bal, Person per) : this(bal)
        {
            vladelec = per;
            cnt++;
            numchet = cnt;
        }

        //методы 

        // добавление средств на счет
        public void Put(int sum)
        {
            balans += sum;
            BankTransactio transactio = new BankTransactio();
            l.Add(transactio.dt);

        }
        // списание средств со счета
        public void Take(int sum)
        {
            if (balans >= sum)
            {
                balans -= sum;
                BankTransactio transactio = new BankTransactio();
                l.Add(transactio.dt);
            }
        }
        //перевод с одного счета на другой
        public void Transaction(BankAccount bankch, double s)
        {
            this.balans -= s;
            bankch.balans += s;
            BankTransactio transactio = new BankTransactio();
            l.Add(transactio.dt);
        }

        //ToString()
        public override string ToString()
        {
            return $"Numchet = {Numchet}, Balans = {Balans}, Vladelec = {Vladelec}";
        }
        public bool Equals(BankAccount b)
        {
            if (b.numchet != this.numchet)
            {
                return false;
            }
            else
            {
                return true;
            }
            return true;
        }
        public static bool operator ==(BankAccount b, BankAccount c)
        {
            if (b.numchet == c.numchet)
            {
                return true;
            }
            else return false;
        }
        public static bool operator !=(BankAccount b, BankAccount c)
        {
            if (b == c)
            {
                return false;

            }
            else
            {
                return true;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Numchet = {Numchet}, Balans = {Balans}, Vladelec = {Vladelec}");

        }

    }
    public interface IPrint
    {
        void Print();
    }
}
