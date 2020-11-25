/*
 * 61. Класс Vector2D - двумерный вектор. Атрибуты - два вещественных числа (координаты).
 * Здесь и далее свойства (get- и set- методы) добавлять по необходимости. 
 * Реализовать следующие методы класса Vector2D
● Vector2D() - конструктор для нулевого вектора;
● Vector2D(double, double) - конструктор вектора с координатами;
● Vector2D add(Vector2D) - сложение вектора с другим вектором, результат возвращается как новый объект.
● void add2(Vector2D) - сложение вектора с другим вектором, результат сохраняется в том, у кого был вызван этот метод;
● Vector2D sub(Vector2D) - вычитание из вектора другого вектора, результат возвращается как новый объект;
● void sub2(Vector2D) - вычитание из вектора другого вектора, результат сохраняется в том векторе, у кого был вызван этот метод;
● Vector2D mult(double) - умножение вектора на вещественное число, результат возвращается как новый объект;
● void mult2(double) - умножение вектора на вещественное число, результат сохраняется в векторе;
● string ToString() - строковое представление вектора;
● double length() - длина вектора;
● double scalarProduct(Vector2D) - скалярное произведение вектора на другой вектор;
● double cos(Vector2D) - косинус угла между этим и другим вектором (не Math.cos, а новый метод cos);
● bool Equals(Vector2D) - сравнить вектор с другим вектором.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_
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
        public Vector2D add(Vector2D vector) { return new Vector2D(this.x + vector.x, this.y + vector.y); }
        public void add2(Vector2D vector) { this.x += vector.x; this.y += vector.y; }
        public Vector2D sub(Vector2D vector) { return new Vector2D(this.x - vector.x, this.y - vector.y); }
        public void sub2(Vector2D vector) { this.x -= vector.x; this.y -= vector.y; }
        public Vector2D mult(double q) { return new Vector2D(this.x * q, this.y * q); }
        public void mult2(double q) { this.x *= q; this.y *= q; }
        public override string ToString() { return $" ({x} ,{y})"; }
        public double length() { return Math.Sqrt(x * x + y * y); }
        public double scalarProduct(Vector2D vector) { return this.x * vector.x + this.y * vector.y; }

        public double cos(Vector2D vector) { return (this.x * vector.x + this.y * vector.y) / this.length() + vector.length(); }
        public bool Equals(Vector2D vector) { return x.Equals(vector.x) && y.Equals(vector.y); }







    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
