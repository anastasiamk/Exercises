/*
 * 49. Даны два массива упорядоченных по возрастанию массива. 
 * Написать метод, который находит пересечение двух массивов,
 * т.е. элементы, которые содержаться в обоих массивах.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49
{
    class Program
    {
        public static void Peresechenie(int[] x, int[] y)
        {
            List<int> peresech = new List<int>();
            foreach(int element_x in x)
            {
                foreach(int element_y in y)
                {
                    if(element_x == element_y)
                    {
                        peresech.Add(element_x);
                        
                    }
                }
            }
            foreach(int i in peresech)
            {
                Console.Write(i);
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            int[] b = new int[5] { 3, 4, 5, 6, 7 };
            Peresechenie(a, b);
        }
    }
}
