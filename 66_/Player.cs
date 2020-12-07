using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66_
{
    class Player
    {
        int age, id;
        static int minage = 17; static int maxage = 19;
        static int cnt;

        public string Name { get; set; }
        public int Age { get; set; }
        public Player(string name, int age)
        {
            if (age >= minage && age <= maxage)
            {
                cnt++;
                id = cnt;
                Name = name;
                Age = age;
            }
            else throw new Exception("недопустимый возраст");
        }
        public Player() { Name = null; Age = 0; }
        public override string ToString()
        {
            return $"name = {Name}, age = {Age}, id = {id}, cnt = {cnt}";
        }
    }
}
