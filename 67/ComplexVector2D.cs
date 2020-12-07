using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CN; //добавлен класс комлексных чисел


namespace CV2D
{
    class ComplexVector2D
    {
        public ComplexNumber x, y;
        public ComplexVector2D()
        {
            x = new ComplexNumber();
            y = new ComplexNumber();
        }
        public ComplexVector2D(ComplexNumber a, ComplexNumber b)
        {
            this.x = a;
            this.y = b;
        }
        public static ComplexVector2D operator +(ComplexVector2D m, ComplexVector2D v)
        {
            return new ComplexVector2D(m.x.add(v.x), m.y.add(v.x));
        }
        
        public ComplexNumber scalarProduct(ComplexVector2D v1)
        {
            ComplexNumber c;
            ComplexNumber d;
            c = this.x * (v1.x);
            d = this.y * (v1.y);
            return (c.add(d));
        }
        public bool Equals(ComplexVector2D v)
        {
            return this.x.Equals(v.x) && this.y.Equals(v.y);
        }
        public override string ToString()
        {
            return $"( {this.x},  {this.y} )";
        }

    }
    
}
