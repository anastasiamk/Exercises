// подается n кол-во строк распечатать картинку

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of lines");
            int n = int.Parse((Console.ReadLine())); // кол-во строк
            for (int i = 1; i <= n; i++) //для длины
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
