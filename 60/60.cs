/*
 * 60. Создать класс ComplexNumber - комплексное число. Атрибуты (поля) - действительная и мнимая части (два числа). Методы:
● ComplexNumber() - конструктор для нулевого комплексного числа;
● ComplexNumber(double, double) - конструктор комплексного числа с заданными значениями вещественной и мнимой части;
● ComplexNumber add(ComplexNumber) - сложение комплексного числа с другим комплексным числом;
● void add2(ComplexNumber) - сложение комплексного числа с другим комплексным числом; Метод возвращает void , т.е. Изменяться будет тот объект класса, который вызывал метод add2: z1.add2(z2) на математическом языке эквивалентно z1+=z2;
● CompexNumber sub(ComplexNumber) - вычитание из комплексного числа другого комплексного числа;\
● void sub2(ComplexNumber) - вычитание из комплексного числа другого комплексного числа;
● ComplexNumber multNumber(double) - умножение комплексного числа на вещественное число;
● void multNumber2(double) - умножение комплексного числа на вещественное число;
● ComplexNumber mult(ComplexNumber) - умножение комплексного числа на другое комплексное число;
● void mult2(ComplexNumber) - умножение комплексного числа на другое комплексное число;
● ComplexNumber div(ComplexN
● void div2(ComplexNumber) - деление на другое комплексное число;
● double length() - модуль комплексного числа;
● string ToString() - строковое представление комплексного числа. Только без всяких "2+-3*i". Проверяйте знаки, чтобы было красиво: 2 - 3*i.
● double arg() - аргумент комплексного числа (может понадобиться тригон ометрическое представление и арктангенс Math.atan);
● ComplexNumber pow(int) - возвести в степень по Формуле Муавра (иные способы запрещены). Внимание - разрешено использование Math.pow для возведения аргумента в степень , также понадобятся Math.cos, Math.sin.
● bool Equals(ComplexNumber) - сравнить комплексное число с другим комплексным числом.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _60
{
    class ComplexNumber
    {
        public double re, im;
        public ComplexNumber(double re, double im) { this.re = re; this.im = im; }
        public ComplexNumber() : this(0.0, 0.0) { }
        
        public ComplexNumber Add(ComplexNumber z)
        {
            return new ComplexNumber(z.re + this.re, z.im + this.im);
        }
        public void Add2(ComplexNumber z)
        {
            this.re += z.re;
            this.im += z.im;
        }
        public ComplexNumber Sub(ComplexNumber z)
        {
            return new ComplexNumber(z.re - this.re, z.im - this.im);
        }
        public void Sub2(ComplexNumber z)
        {
            this.re -= z.re;
            this.im -= z.im;
        }
        public ComplexNumber MultNumber(double x)
        {
            return new ComplexNumber(this.re * x, this.im * x);
        }
        public void Mult2(ComplexNumber z)
        {
            this.re *= z.re;
            this.im *= z.im;
        }
        public ComplexNumber Mult(ComplexNumber z)
        {
            return new ComplexNumber(this.re * z.re - this.im * z.im,
                                    this.re * z.im + this.im * z.re);
        }
        public void mult2(ComplexNumber z)
        {
            this.re = this.re * z.re - this.im * z.im;
            this.im = this.re * z.im + this.im * z.re;
        }
        ComplexNumber div(ComplexNumber z)
        {
            return new ComplexNumber((this.re * z.re + this.im * z.im) / (z.re * z.re + z.im * z.im), (z.re * this.im - this.re * z.im) / (z.re * z.re + z.im * z.im));
        }
        void div2(ComplexNumber z)
        {
            this.re = (this.re * z.re + this.im * z.im) / (z.re * z.re + z.im * z.im);
            this.im = (z.re * this.im - this.re * z.im) / (z.re * z.re + z.im * z.im);
        }
        public double length()
        {
            return Math.Sqrt(this.re * this.re + this.im * this.im);
        }
        public string ToString()
        {
            if (this.im > 0)
                return $"{this.re} + {this.im}i";
            else
                return $"{this.re} {this.im}i";
        }
        public double Arg()
        {
            double eps = 1e-10;
            if (re > eps && Math.Abs(im) < eps)
                return 0;
            if (re > eps && im > eps)
                return Math.Atan(Math.Abs(im / re));
            if (Math.Abs(re) < eps && im > eps)
                return Math.PI * 0.5;
            if (re < -eps && im > eps)
                return Math.PI - Math.Atan(Math.Abs(im / re));
            if (re < -eps && im < -eps)
                return Math.PI;
            if (re < -eps && im < -eps)
                return -Math.PI + Math.Atan(Math.Abs(im / re));
            if (re < -eps && im < -eps)
                return -Math.PI * 0.5;
            if (re > eps && im < -eps)
                return -Math.Atan(Math.Abs(im / re));

            return Math.Atan(im / re);
        }
        public double Module { get { return Math.Sqrt(re * re + im * im); } }

        public double Argument { get { return Arg(); } }
        public static ComplexNumber ComplexTrigonometricNumber(double arg, double mod)
        {
            return new ComplexNumber(mod * Math.Cos(arg), mod * Math.Sin(arg));
        }

        public ComplexNumber Pow( int pow)
        {
            
            return ComplexNumber.ComplexTrigonometricNumber(pow * this.Argument, Math.Pow(this.Module, pow));
        }

        public bool Equals(ComplexNumber z)
        {
            if (z is null)
            {
                return false;
            }
            return re.Equals(z.re) && im.Equals(z.im);
        }




    }


    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber z1 = new ComplexNumber(2, -3);
            ComplexNumber z2 = new ComplexNumber(1, -2);
            Console.WriteLine(z2.Pow(3));
            

        }
    }
}
