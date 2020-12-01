//64.Добавить в класс Vector2D следующие операции:
//● Операция сложения вектора с другим вектором (operator +);
//● Операция вычитания из вектора другого вектора (operator -);
//● Операция умножения вектора на вещественное число (operator *);
//● Операция деления вектора на вещественное число (operator /);
//● Операция проверки равны ли два вектора между собой (operator == и !=).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64
{
    class Vector2D
    {
        double x, y;
        public double X
        {
            get
            {
                return x;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
        }

        public Vector2D(double x, double y) { this.x = x; this.y = y; }
        public Vector2D() : this(0.0, 0.0) { }
        
        public static Vector2D operator +(Vector2D vector, Vector2D w)
        { return new Vector2D(w.x + vector.x, w.y + vector.y); }

        public static Vector2D operator -(Vector2D vector, Vector2D w)
        { return new Vector2D(w.x + vector.x, w.y + vector.y); }

        //не хватает операторов

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
