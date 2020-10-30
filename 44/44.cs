//44. Написать метод, который добавляет в массив элемент в позицию j.
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44
{
    class Program
    {
        
        public static void AddElement(ref int[] array, ref int j)
        {
            int[] c = new int[array.Length + 1];
            for(int i = 0; i <= array.Length; i++)
            {
                if(i == j)
                {
                    Console.WriteLine("enter element: ");
                    c[i] = int.Parse(Console.ReadLine());

                }
                else if (i < j)
                {
                    c[i] = array[i];
                }
                else if (i > j)
                {
                    c[i] = array[i - 1 ];
                }

            }
            array = new int[c.Length];
            for(int i = 0; i< array.Length; i++)
            {
                array[i] = c[i];
            }

        }
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 5, 7, 9 };
            int j = 3;

            AddElement(ref array, ref j);
            foreach(int element in array)
            {
                Console.Write(element + " ");
            }
        }
    }
}
