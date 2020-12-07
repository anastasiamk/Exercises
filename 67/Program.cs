//67.Класс ComplexVector2D - двумерный вектор, компоненты которого являются комплексными числами 
//    (т.е. Объектами созданного класса ComplexNumber). Это и есть атрибуты класса. Методы:
//● ComplexVector2D() - конструктор для нулевого вектора (компоненты должны быть равны нулевым комплексным числам);
//● ComplexVector2D(ComplexNumber, ComplexNumber) - конструктор вектора с координатами;
//в конструкторах устраняйте дублирование кода;
//● ComplexVector2D operator +(ComplexVector2D, ComplexVector2D) -сложение вектора с другим вектором;
//● string ToString() -строковое представление вектора;
//● ComplexNumber scalarProduct(ComplexVector2D) -скалярное произведение вектора на другой вектор;
//● boolean equals(ComplexVector2D) -сравнить вектор с другим вектором.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CN; 
using CV2D; 

namespace _67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("конструктор для нулевого вектора (компоненты должны быть равны нулевым комплексным числам)");
            ComplexVector2D a = new ComplexVector2D();
            Console.WriteLine(a.ToString());

            Console.WriteLine("конструктор вектора с координатами");
            ComplexNumber b = new ComplexNumber(2, 3);
            ComplexNumber c = new ComplexNumber(3, 4);
            ComplexVector2D d = new ComplexVector2D(b, c);
            Console.WriteLine(d);

            Console.WriteLine("сложение вектора с другим вектором;");
            ComplexNumber p = new ComplexNumber(2, 3);
            ComplexNumber g = new ComplexNumber(1, 4);
            ComplexVector2D f = new ComplexVector2D(p, g);
            Console.WriteLine(f+d);

            Console.WriteLine("скалярное произведение вектора на другой вектор");
            Console.WriteLine(f.scalarProduct(d));

            Console.WriteLine("сравнить вектор с другим вектором.");
            Console.WriteLine(f.Equals(d));
        }
    }
}
