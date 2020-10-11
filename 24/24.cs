//24. Для введенного n вывести «трифорс» (пример ниже), 
//n - высота каждого треугольника. Не использовать строки и массивы символов. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int center = 2*n+1; // From our example.
            int center_L = center - n;
            int center_R = center + n;

            for (int row = 0; row < n; ++row)
            {
                for (int column = 0; column < center * 2 - n; ++column)
                {
                    if (column >= center - row && column <= center + row)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }


            for (int row = 0; row < n; ++row)
            {
                for (int column = 0; column < center; ++column)
                {
                    if (column >= center_L - row && column <= center_L + row)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }

                for (int column = center; column <= center*2+n; ++column)
                {
                    if (column >= center_R - row && column <= center_R + row)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }



                Console.WriteLine();


            }
           


        }

    }

}
