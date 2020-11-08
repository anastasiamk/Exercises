/*56. Вводится целочисленная квадратная матрица размера 2n+1. 
 * Написать метод, который заменяет нулями элементы, расположенные на верхнем и нижнем треугольниках, 
 * образованных пересечением главной и побочной диагоналей. Правый и левый треугольники не трогать.
 * Пример:

Вход:
1 2 3 4 5
2 3 4 1 2
0 3 2 3 1
9 2 3 1 4
3 8 0 8 6

Выход:
1 0 0 0 5
2 3 0 1 2
0 3 2 3 1
9 2 0 1 4
3 0 0 0 6

*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56
{
    class Program
    {
        public static void Tri(int[,] a)
        {
            long str = a.GetLongLength(0);
            int st = Convert.ToInt32(str);

            for (int j = 0; j < st; j++)
            {
                for (int i = 0; i < st; i++)
                {
                    if((i!=j)&&(j != str - i - 1))
                    {
                       if( (i>j)&&(j> str - i - 1))
                       {
                            a[i, j] = 0;
                       }
                       if ((i < j) && (j < str - i - 1))
                       {
                            a[i, j] = 0;
                       }

                    }
                    
                    
                }
                
            }

            for(int h= 0; h<st; h++)
            {
                for (int v = 0; v < st; v++)
                {
                    Console.Write(a[h, v]);
                }
                Console.WriteLine();
            }
            
        }
        static void Main(string[] args)
        {
            int[,] a = { { 1, 7, 1, 5,3 }, { 1, 6, 5, 4, 3}, { 2, 6, 4, 5, 3}, { 2, 6, 4, 5, 3 } , { 2, 6, 4, 5, 3 } };
            Tri(a);
            
        }
    }
}
