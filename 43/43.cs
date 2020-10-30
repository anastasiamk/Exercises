//43. написать программу, которая удаляет все элементы в массиве между минимальным и максимальным.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6] { 2, 3, 1, 7, 3, 8 };
            
            int? max = null;
            int? min = null;
            

            for(int i = 0; i < array.Length; i++)
            {
                if( (array[i] > max)||(max == null) )
                {
                    max = array[i];

                }
                if( (array[i] < min) || (min == null) )
                {
                    min = array[i];
                }
            }
            int[] c = new int[array.Length - (Array.IndexOf(array, max) - Array.IndexOf(array, min) - 1 )];
            int j = 0;
           
            for(int i = 0; i <= Array.IndexOf(array, min); i++, j++) 
            {
                c[j] = array[i];
            }
            for (int i = Array.IndexOf(array, max); i < array.Length; i++, j++)
            {
                c[j] = array[i];
                

            }
            array = new int[c.Length];
            for (int i = 0; i < c.Length; i++)
            {
                array[i] = c[i];
                Console.Write($"{array[i]} ");
            }
            
            

            
        }
    }
}
