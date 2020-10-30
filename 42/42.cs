/*
 * 42. Дан отсортированный по возрастанию массив. Вводится число k. 
 * Найти число k в массиве методом деления пополам (алгоритм бинарного поиска), 
 * вывести индекс элемента массива, если такой есть. 
 * Количество элементов массива может быть нечетным. Написать метод. Рекурсию не использовать.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42
{
    class Program
    {
        
        public static void ItemSearch(int[] array, int key)
        {
            int l = 0; // left border
            int r = array.Length-1; //right border //6
            int sredn = (l + r) / 2; ;
            bool f = false;

            while ((l <= r) && (f != true))
            {
                sredn = (l + r) / 2; // sredn index [l,r] //3 -16

                if (array[sredn] == key) // check sredn
                {
                    f = true;
                    break;
                }
                if (array[sredn] > key) //16
                {
                    r = sredn - 1; // отбросить
                }
                else
                {
                    l = sredn + 1;
                }
            }
            if (f)
            {
                Console.WriteLine(sredn);
            }
            else
            {
                Console.WriteLine("element is absent");
            }

        }

        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[7] { 1, 5, 8, 16, 25, 50, 100};
            ItemSearch(array, k);

        }
    }
}
