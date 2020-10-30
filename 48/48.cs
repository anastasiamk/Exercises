//48. Дана матрица. В каждом ее столбце посчитать количество отрицательных элементов. 
//Результат записать в массив. Распечатать элементы полученного массива на экран.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48
{
    class Program
    {

        static void Main(string[] args)
        {

            int n = 2; // string
            int m = 3;


            int[,] a = new int[n, m];
            int[] c = new int[m];

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = r.Next(-2, 3);
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }



            int sum = 0;

            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if(a[i, j] < 0)
                    {
                        sum += 1 ;
                    }
                }
                c[j] = sum;
                sum = 0;

            }

            foreach (int element in c)
            {
                Console.Write(element+" ");
            }

        }
    }
}
