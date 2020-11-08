//51. Дана квадратная матрица. Распечатать элементы диагонали, 
//которая параллельна главной диагонали и имеет максимальную сумму элементов.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51
{
    class Program
    {
        public static void MaxD(int[,] a)
        {
            long str = a.GetLongLength(0);
            int st = Convert.ToInt32(str);
            int sum = 0;
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            List<int> l1 = new List<int>();
            List<int> l1_control = new List<int>();
            List<int> l2 = new List<int>();
            List<int> l2_control = new List<int>();

            for (int j = 1; j < st; j++)
            {
                for (int i = j; i < st; i++)
                {
                    sum += a[i, (i - j)];
                    l1.Add(a[i, (i - j)]);
                }
                if(sum > max1)
                {
                    max1 = sum;
                    l1_control = new List<int>(l1);
                }
                sum = 0;
                l1.Clear();

            }

            for (int j = 1; j < st; j++)
            {
                for (int i = j; i < st; i++)
                {
                    sum += a[(i - j), i];
                    l2.Add(a[(i - j), i]);
                }
                if (sum > max2)
                {
                    max2 = sum;
                    l2_control = new List<int>(l2);
                }
                sum = 0;
                l2.Clear();

            }

            if (max2 > max1)
            {
                foreach(int i in l2_control)
                {
                    Console.Write(i + "\t");
                }
                
            }
            else
            {
                foreach (int i in l1_control)
                {
                    Console.Write(i + "\t");
                }

            }
            

        }
        static void Main(string[] args)
        {
            int[,] a = { { 1, 7, 1, 5 }, {1, 6, 5, 7 }, { 2, 6, 4, 200 }, { 2, 5, 4, 3} };
            MaxD(a);
            
        }
    }
}
