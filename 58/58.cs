//58. Задача слияния. Даны два упорядоченных по возрастанию массива. 
//Написать метод, который объединяет два массива, т.е. получает третий массив, элементами которого
//являются элементы первого и второго массивов, третий массив
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58
{
    class Program
    {
        public static int[] Sll(int[] left, int[] right)
        {
            var length = left.Length + right.Length;
            var leftPointer = 0;
            var rightPointer = 0;

            int[] result = new int[length];
            int m = 0;
            for (int i = 0; i < length; i++)
            {
                if (leftPointer < left.Length && rightPointer < right.Length)
                {
                    if (left[leftPointer] < right[rightPointer])
                    {
                        result[m] = left[leftPointer];
                        m++;
                        leftPointer++;
                    }
                    else
                    {
                        result[m] = right[rightPointer];
                        m++;
                        rightPointer++;
                    }
                }
                else
                {
                    if (rightPointer < right.Length)
                    {
                        result[m] = (right[rightPointer]);
                        m++;
                        rightPointer++;
                    }
                    else
                    {
                        result[m] = (left[leftPointer]);
                        m++;
                        leftPointer++;
                    }
                }
            }
            
            return result;
        }


    

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3,  4, 5, 6 };
            int[] b = { 6, 7, 8  };
            
            Sll(a, b);


        }
    }
}
