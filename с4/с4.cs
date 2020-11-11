/*С4. Написать метод, который проверяет является  ли натуральное число палиндромом. 
 * Числовой палиндром –это натуральное число, которое читается слева направо и справа налево одинаково. 
 * Иначе говоря, отличается симметрией записи (расположения цифр),причем число знаков 
 * может быть как четным, так и нечетным.
 */
 
  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace с4
{
    class с4
    {
        public static bool Palin(int a)
        {

            bool f = true;
            int col = a.ToString().Length;
            int[] massive = new int[col];
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = a % 10;
                a /= 10;

            }
            for (int k = 0; k < massive.Length / 2; k++)
            {
                if (massive[k] != massive[massive.Length - k - 1])
                {
                    f = false;
                }
            }
            return f;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Palin(a));

        }
    }
}
