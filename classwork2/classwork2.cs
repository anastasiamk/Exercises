// (Σ i=0; n;)   ( 2^(i+1)*(2i+1) ) / i!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork2
{
    class classwork2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter n: ");
            double n = Convert.ToDouble(Console.ReadLine());
            double i = 1;
            double dr = 2 / i;
            double s = 0;
            double s1 = dr;
            do
            {
                s = s1;
                dr *= (2 / i);
                s1 = s + dr * (i*2+1);
                i++;

                
            }
            while (i <= n);
            {
                Console.WriteLine(s1);
            }

        }
    }
}
