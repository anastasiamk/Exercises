/*
 * С3*. Для  каждого  целого  числа из диапазона от a до b построить 
 * цифровой код  числа. Цифровым  корнем  называется  число,  
 * полученное  из  цифр  исходного  числа  путем  их сложения и 
 * повторения этого процесса над полученной суммой до тех пор, 
 * пока не будет получено число меньшее 10. Например цифровой код числа 467 равен 8.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c3
{
    class c3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter b");
            int b = Convert.ToInt32(Console.ReadLine());

            int s = 0;
            int sum = 0;
            int sum1 = 0;

            for (int i = a; i <= b; i++)
            {
                s = i;
                sum = s;
                while (sum >= 10)
                {
                    s = sum;
                    while (s > 0)
                    {
                        sum1 += s % 10;
                        s /= 10;
                    }
                    sum = sum1;
                    sum1 = 0;
                }
                Console.WriteLine(sum);


            }
        }
    }
}
