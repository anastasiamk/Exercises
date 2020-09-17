/*
 * Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ,
 * КХТИ}. Создать структуру работник с двумя полями: имя, ВУЗ. Заполнить
 * структуру данными и распечатать.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3._1
{
    class Program
    {
        public enum University { КГУ, КАИ, КХТИ}
        public struct Employee
        {
            public string name;
            public University university1;
        }
        static void Main(string[] args)
        {
            Employee user1;
            user1.name = "Alex";
            user1.university1 = University.КГУ;
            Console.WriteLine("Employee name: {0}, University: {1}", user1.name, user1.university1);
        }
    }
}
