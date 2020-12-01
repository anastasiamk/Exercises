//63.Добавить в класс ComplexNumber свойства (get и set методы), реализовать операции сложения,
//вычитания, умножения, деления комплексных чисел, которые будут возвращать новый объект класса. 
//    Операции сложения, вычитания, умножения, деления сделать перегруженными: чтобы можно было работать
//    с двумя комплексными числами, и чтобы можно было комплексное число складывать (вычитать, умножать, делить)
//    с(на) вещественным, т.е.для сложения:

////ComplexNumber operator +(ComplexNumber, ComplexNumber)

////ComplexNumber operator +(CompllexNumber, double d).

////Первый вариант для возможности писать z1=z2+z3; 
//второй для z1=z2+f, где z1, z2, z3 комплексные числа, а f - вещественное число.
//    Будет ли второй вариант работать в следующем виде z3=f+z1 ?

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63_
{
    class ComplexNumber
    {
        double re, im;
        public double Re { get; } //это автосвойство, для него автоматически создаться соответствуещее private поле, тогда получится два поля для хранения вещественной части, не связанных друг с другом.
        public double Im { get; }

        public ComplexNumber(double re, double im) { this.re = re; this.im = im; }
        public ComplexNumber() : this(0.0, 0.0) { }
        public ComplexNumber(double re) { this.re = re; }

        public static ComplexNumber operator +(ComplexNumber z, ComplexNumber b)
        {
            return new ComplexNumber(z.re + b.re, z.im + b.im);
        }
        //z+d можно делать, a d*z - нельзя
        public static ComplexNumber operator +(ComplexNumber z, double d)
        {
            return new ComplexNumber(z.re + d, z.im);
        }

        public static ComplexNumber operator -(ComplexNumber z, ComplexNumber b)
        {
            return new ComplexNumber(z.re - b.re, z.im - b.im);
        }
        public static ComplexNumber operator -(ComplexNumber z, double d)
        {
            return new ComplexNumber(z.re - d, z.im);
        }

        public static ComplexNumber operator *(ComplexNumber b, ComplexNumber z)
        {
            return new ComplexNumber(b.re * z.re - b.im * z.im,
                                   b.re * z.im + b.im * z.re);
        }
        public static ComplexNumber operator *(ComplexNumber b, double f)
        {
            return new ComplexNumber(b.re * f, b.im * f);
        }

        public static ComplexNumber operator /(ComplexNumber b, ComplexNumber z)
        {
            return new ComplexNumber((b.re * z.re + b.im * z.im) / (z.re * z.re + z.im * z.im), (z.re * b.im - b.re * z.im) / (z.re * z.re + z.im * z.im));
        }
        public static ComplexNumber operator /(ComplexNumber b, double f)
        {
            return new ComplexNumber(b.re / f, b.im / f);
        }
        public override string ToString()
        {
            if (this.im > 0)
                return $"{this.re} + {this.im}i";
            else
                return $"{this.re} {this.im}i";

        }
    }
        class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
