/*
 * С5. Найти сумму положительных элементов целочисленного массива размера n, если верно,
 * что  каждый  третий (ориентироваться  не  на  индекс  элемента,  а  на  его  фактическую позицию) 
 * элемент массива делится на три. Иначе найти произведение положительных элементов массива. 
 * Для проверки условия делимости на три каждого третьего элемента массива написать отдельный метод.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace с5
{
    class с5
    {
        public static bool Del3(int[] a)
        {
            bool f = true;
            for (int i = 2; i < a.Length; i += 3)
            {
                if (a[i] % 3 != 0)
                {
                    f = false;
                }
            }
            return f;
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 1, 3, 4, 5, 6 };
            int sum = 0;
            int proiz = 1;

            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] > 0) && (Del3(a) == true))
                    sum += a[i];
                if ((a[i] > 0) && (Del3(a) != true))
                    proiz *= a[i];
            }
            if (Del3(a))
            {
                Console.WriteLine($"sum = {sum}");
            }
            else
            {
                Console.WriteLine($"proiz = {proiz}");
            }

        }
    }
}
