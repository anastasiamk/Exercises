/*
 * 34. Игра «Ханойские башни» состоит в следующем. Есть три стержня. 
 * На первый из них надета пирамидка из N колец (большие кольца снизу, меньшие сверху).
 * Требуется переместить кольца на другой стержень. 
 * Разрешается перекладывать кольца со стержня на стержень, но класть 
 * большее кольцо поверх меньшего нельзя. Написать рекурсивный метод,
 * печатающий на экран требуемые действия для перемещения всех колец на другой стержень.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    class Program
    {
        public static void Hanoi(int n, int i, int k)
        {
            if (n == 1)
            {
                Console.WriteLine("Переложите диск 1 с {0} на {1}", i, k);
            }
            else
            {
                int vrem = 6 - i - k;
                Hanoi(n - 1, i, vrem);
                Console.WriteLine("Переложите диск {0} с {1} на {2}", n, i, k);
                Hanoi(n - 1, vrem, k);
            }
        }
        static void Main(string[] args)
        {
            Hanoi(3, 1, 2);
        }
    }
}
