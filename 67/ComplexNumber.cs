using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CN

{
    public class ComplexNumber
    {
        double re, im;
        public double Re { get; set; }
        public double Im { get; set; }

        public ComplexNumber(double re, double im) { this.re = re; this.im = im; }
        public ComplexNumber() : this(0.0, 0.0) { }
        public ComplexNumber(double re) { this.re = re; }
        public ComplexNumber add(ComplexNumber z)
        {
            return new ComplexNumber(z.re + this.re, z.im + this.im);
        }
        public static ComplexNumber operator +(ComplexNumber z, ComplexNumber b)
        {
            return new ComplexNumber(z.re + b.re, z.im + b.im);
        }
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
        public bool Equals(ComplexNumber z)
        {
            if (z is null)
            {
                return false;
            }
            return re.Equals(z.re) && im.Equals(z.im);
        }
        public override string ToString()
        {
            if (this.im > 0)
                return $"{this.re} + {this.im}i";
            else
                return $"{this.re} {this.im}i";

        }
    }
}
