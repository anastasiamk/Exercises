using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contr_work_3
{
    class Person
    {
        private string name;
        private int pasport;
        private int number;
        //свойства
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Pasport
        {
            get
            {
                return pasport;
            }
            set
            {
                pasport = value;
            }

        }
        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        //конструкторы
        public Person()
        {
            name = null;
            pasport = 0;
            number = 0;

        }
        public Person(string n)
        {
            Name = n;
        }
        public Person(string n, int p) : this(n)
        {
            Pasport = p;
        }
        public Person(string n, int p, int num) : this(n, p)
        {
            Number = num;
        }

        //ToString()
        public override string ToString()
        {
            return $"Name = {Name}, Paspor = {Pasport}, Number = {Number}";
        }

    }
}
