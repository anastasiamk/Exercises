//29. Написать метод, который увеличивает передаваемое в метод число на единицу.
// Параметр передавать по ссылке.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_
{
    class Program
    {
        public static void Add1(ref int k)
        {
            k += 1;
        }
        static void Main(string[] args)
        {
            int s = 25;
            Add1(ref s);
            Console.WriteLine(s);
        }
    }
}
