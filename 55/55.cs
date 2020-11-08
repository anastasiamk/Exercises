//55. Написать метод, который проверяет, 
//что в двумерном массиве каждая сумма элементов на побочных диагоналях является четной

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55
{
    class Program
    {
        public static bool ChetnM(int[,] a)
        {
            int str = Convert.ToInt32(a.GetLongLength(0));
            int sum = 0;
            bool f = true;
            for (int j = 0; j < str; j++)
            {
                for (int i = 0; i <= j; i++)
                {
                    sum += a[i, (j - i)];
                }
                if (sum % 2 != 0)
                {
                    f = false;
                    break;
                }
                sum = 0;

            }
            return f;

        }
        static void Main(string[] args)
        {
            int[,] a = new int[,] { { 2, 2, 2, 4 }, { 2, 2, 2, 4 }, { 0, 2, 2, 2 }, { 8, 4, 2, 8} };
            ChetnM(a);

            
        }
    }
}
