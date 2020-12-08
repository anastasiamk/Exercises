using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68_
{
    abstract class Figure
    {
        string color;
        string status;
        public abstract void MovingHorizon(int x);
        public abstract void MovingVertical(int y);

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public abstract double Area();
        

    }
}
