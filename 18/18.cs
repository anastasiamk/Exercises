/*
 * 18.Вывести все числа из диапазона от 1 до N задом наперед,
 * т.е. если было число 12, то надо напечатать ,21, 
 * вместо числа 13 напечатать 31.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            string w = "";
            

            for (int i = 0; i <= n; i++)
            {
                w += Convert.ToString(i);
            }

            char[] array = w.ToCharArray();
            for (int k = w.Length-1; k >= 0; k--)
            {
                Console.Write(w[k]);
            }
            
        }
    }
}
