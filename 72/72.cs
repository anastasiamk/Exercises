//72. Даны два массива одинакового размера.
//В одном массиве хранятся gps- координаты точек заданного маршрута.
//Во втором массиве хранятся gps- координаты точек маршрута, по которому проехала служебная техника. 
//Написать метод, который определяет, отклонялась ли служебная техника от маршрута. 
//Точка - это структура с двумя полями типа double. Z-координату не учитываем.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72
{
    class Program
    {
        struct Point
        {
            public double x;
            public double y;
        }
        static void Main(string[] args)
        {
            Point p1;
            p1.x = 1; p1.y = 1;

            Point p2;
            p2.x = 2; p2.y = 2;

            Point p3;
            p3.x = 7; p3.y = 3;
            //
            Point p4;
            p4.x = 1; p4.y = 1;

            Point p5;
            p5.x = 2; p5.y = 2;

            Point p6;
            p6.x = 3; p6.y = 3;

            Point[] a = new Point[] { p1, p2, p3};
            Point[] b = new Point[] { p4, p5, p6};


            bool Iqal(Point[] l, Point[] o)
            {
                bool f = true;
                for(int i = 0; i < l.Length; i++)
                {
                    if(l[i].x != o[i].x || l[i].y != l[i].y)
                    {
                        f = false;
                        break;
                    }
                }
                return f;
            }

            Console.WriteLine(Iqal(a, b));

        }

        
    }
}
