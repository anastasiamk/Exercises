using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66_
{
    class Program
    {
        static void Main(string[] args)
        {
            Team t1 = new Team() { Name = "sun" };
            Player p1 = new Player() { Name = "Sasha", Age = 18 };
            Player p2 = new Player() { Name = "Dima", Age = 17 };
            Player p3 = new Player() { Name = "Dima", Age = 18 };
            t1[0] = p1;
            t1[1] = p1;
            Console.WriteLine(t1["Sasha"]);
            t1.Add(p2);
            t1.Detite(p1);
            //t1.Print(t1);

        }
    }
}
