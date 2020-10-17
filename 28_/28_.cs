//28. Написать метод, который натуральное число переворачивает в обратном порядке
//(число 1234 превращается в 4321). Методу параметр передавать по ссылке. 
//В результате работы метода должно меняться само исходное число.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_
{
    class Program
    {
        public static void TurnOver1(ref int n)
        {
            string w = "";

            while(n > 0)
            {
                w += n % 10;
                n /= 10;
            }
            n = int.Parse(w);


        }
        static void Main(string[] args)
        {
            int a = 23598;
            TurnOver1(out a);
            Console.WriteLine(a);
        }
    }
}
