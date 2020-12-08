using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68_
{
    class Rectangle : Point, IPrintable
    {
        public double Width { get { return Math.Abs(Raight_Upper.X - Left_Lower.X); } }
        public double Height { get { return Math.Abs(Raight_Upper.Y - Left_Lower.Y); } }


        public Point Raight_Upper { get; set; }//правый верхний угол
        public Point Left_Upper { get; set; } //левый верхний угол
        public Point Raight_Lower { get; set; } //правый нижний
        public Point Left_Lower { get; set; }//левый нижний

        public override void MovingHorizon(int x)
        {
            Raight_Upper.X += x;
            Left_Upper.X += x;
            Raight_Lower.X += x;
            Left_Lower.X += x;
        }
        public override void MovingVertical(int y)
        {
            Raight_Upper.Y += y;
            Left_Upper.Y += y;
            Raight_Lower.Y += y;
            Left_Lower.Y += y;
        }

        public override double Area()
        {
            return Width * Height;
        }
        public override void Print()
        {
            Console.WriteLine($"color = {Color}, status  = {Status},  высота = {Height}, длина = {Width}, координаты: " +
                $"правый верхний угол = {Raight_Upper},левый верхний угол = {Left_Upper},правый нижний = {Raight_Lower}, " +
                $"левый нижний = {Left_Lower}");
        }
    }
}
