//53. Реализовать с помощью двумерных массивов умножение матриц.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53
{
    class Program
    {
        public static int[,] MultiplicationM(int[,] a, int[,] b)
        {
            int stra = Convert.ToInt32(a.GetLongLength(0));
            int stolba = Convert.ToInt32(a.GetLongLength(1));

            int strb = Convert.ToInt32(b.GetLongLength(0));
            int stolbb = Convert.ToInt32(b.GetLongLength(1));

            int[,] c = new int[stra, stolbb];

            if (stolba != strb)
            {
                Console.WriteLine("Умножение невозможно");
            }

            for (int i = 0; i < stra; i++)
            {
                for (int j = 0; j < stolbb; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < stolba; k++)
                    {
                        c[i, j] += (a[i, k] * b[k, j]);
                    }

                }
            }
            return c;

        }
        static void Main(string[] args)
        {
            int[,] a = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] b = new int[,] { { 7, 8 }, { 9, 1 }, { 2, 3 } };

            MultiplicationM(a, b);
            
        }
    }
}
