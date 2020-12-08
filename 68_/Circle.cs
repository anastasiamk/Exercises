using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68_
{
    class Circle : Point, IPrintable
    {
        public double Radius { get; set; }
        public Point Center { get; set; } //координаты центра

        public override void MovingHorizon(int x)
        {
            Center.X += x;
        }
        public override void MovingVertical(int y)
        {
            Center.Y += y;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override void Print()
        {
            Console.WriteLine($"color = {Color}, status  = {Status}, центр окружности: {Center}, радиус = {Radius}");
        }
    }
}
