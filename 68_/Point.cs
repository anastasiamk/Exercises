using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68_
{
    class Point : Figure, IPrintable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public override void MovingHorizon(int x)
        {
            X += x;
        }
        public override void MovingVertical(int y)
        {
            Y += y;
        }
        public override double Area()
        {
            return 0;
        }
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        public virtual void Print()
        {
            Console.WriteLine($"color = {Color}, status  = {Status}, координаты точки:({X}, {Y})");
        }
    }
}
