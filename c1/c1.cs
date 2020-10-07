//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace c1
{
    class c1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter x");
            double x = Convert.ToDouble(Console.ReadLine());
            double s = 0;
            double eps = 0.000001;
            double dr = 1;
            double s1 = dr;
            double i = 1;

            do
            {
                s = s1;
                dr *= (-1) * (2 * i - 1) * (2 * i) * x / (i * i * 4);
                s1 = s + dr / (1 - 2 * i);
                i++;
            }
            while (Math.Abs(s1 - s) > eps);
            {
                Console.WriteLine(s1);
                Console.WriteLine(Math.Sqrt(1 + x));

            }
        }
    }
}
