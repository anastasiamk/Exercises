//50. Для каждой строки матрицы найти ее максимальный элемент в строке, и минимальный элемент в столбце.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 2, 7, 1, 5 }, { 9, 6, 5, 7 }, { 2, 6, 4, 0 } };
            long str = a.GetLongLength(0) ;
            long stolb = a.GetLongLength(1);
            int? max = null;
            int? minim = null;
            
            for(int j = 0; j<stolb; j++ )
            {
                for(int i = 0; i<str; i++)
                {
                    
                    if ((minim == null) || (a[i, j] < minim))
                    {
                        minim = a[i, j];
                    }
                    
                }
                Console.WriteLine($"min = {minim}");
                max = (minim = null);

            }
            
            for(int i = 0; i < str; i++)
            {
                for(int j = 0; j < stolb; j++)
                {
                    if ((max == null) || (a[i, j] > max))
                    {
                        max = a[i, j];
                    }
                }
                Console.WriteLine($"max = {max}");
                max = (minim = null);

            }

        }
    }
}
