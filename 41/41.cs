/*
 * 41. Дан массив. Написать метод, который определяет, являются ли элементы массива уникальными,
 * т.е. каждый элемент встречается в массиве один раз.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41
{
    class Program
    {
        public static void RandomArray(params int[] array)
        {
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-10, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        public static bool Unicli(int[] array)
        {
            bool f = true;
            for(int i  = 0; i < array.Length; i++)
            {
                for(int k = 0; k < array.Length; k++)
                {
                    if (i != k)
                    {
                        if (array[i] == array[k])
                        {
                            f = false;
                            break;
                        }
                    }
                
                }

            }
            return f;

        }
        static void Main(string[] args)
        {
            int[] array = new int[5];
            RandomArray(array);

            Console.WriteLine(Unicli(array));

        }
    }
}
