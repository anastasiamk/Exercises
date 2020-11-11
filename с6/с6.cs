/*
 * С6. Написать метод,  который  проверяет является  ли матрица верхнетреугольной  или нижнетреугольной. 
 * В  методе Main  задать матрицу, вызвать для нее метод проверки и напечатать результат. Матрица является верхнетреугольной, если под главной диагональною все элементы равны нулю.
 * Матрица является нижнетреугольной, если над главной диагональю все элементы равны нулю.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace с6
{
    class с6
    {
        public static string Tri(int[,] a)
        {
            string s = "";
            bool f = true;// верхний
            bool r = true; //нижний

            for (int j = 1; j < a.GetLongLength(0); j++)
            {
                for (int i = j; i < a.GetLongLength(0); i++)
                {
                    if (a[i, (i - j)] != 0)
                        f = false;
                }

            }
            for (int j = 1; j < a.GetLongLength(0); j++)
            {
                for (int i = j; i < a.GetLongLength(0); i++)
                {
                    if (a[(i - j), i] != 0)
                        r = false;

                }
            }
            if (f) { s = "верхнетреугольная"; }
            if (r) { s = "нижнетреугольная"; }
            if (!f && !r) { s = "не является верхне- или нижнетреугольной"; }
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter m:");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < a.GetLongLength(0); i++) //задается матрица
                for (int j = 0; j < a.GetLongLength(1); j++)
                {
                    Console.WriteLine("enter element: ");
                    a[i, j] = int.Parse(Console.ReadLine());

                }

            //int[,] a = new int[,] { { 1, 0, 0 }, { 5, 2, 0 }, { 6, 4, 0 } };
            Console.WriteLine(Tri(a));

        }
    }
}
