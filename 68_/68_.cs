////68. Создать класс Figure для работы с геометрическими фигурами. 
//В качестве полей класса задаются цвет фигуры, состояние “видимое/невидимое”. 
//Предусмотреть методы: передвижение геометрической фигуры по горизонтали, 
//по вертикали (как изменение ее координат); изменения цвета, опрос состояния (видимый/невидимый); 
//метод вывода на экран, который выводит значения всех полей объекта. Подумать, нужны ли виртуальные методы, 
//каким методы будут виртуальными.

//Создать класс Point (точка) как потомок геометрической фигуры.
//Создать класс Circle (окружность) как потомок точки. 
//В класс Circle добавить метод, который вычисляет площадь окружности.
//Создать Rectangle (прямоугольник) как потомок точки, реализовать метод вычисления площади прямоугольника.
//Точка, окружность, прямоугольник должны поддерживать методы передвижения по горизонтали и вертикали, изменения цвета
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68_
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point() { X = 4, Y = 2 };
            Point p2 = new Point() { X = 4, Y = 0 };
            Point p3 = new Point() { X = 0, Y = 2 };
            Point p4 = new Point() { X = 0, Y = 0 };
            p1.Color = "синий"; p1.Status = "видимая";
            p2.Color = "красный"; p2.Status = "невидимая";
            p1.MovingHorizon(1);
            p2.MovingVertical(1);
            Console.WriteLine(p1.Area());
            p1.Print();
            p2.Print();

            Circle c1 = new Circle() { Radius = 2, Center = p1 };
            c1.Color = "синий"; c1.Status = "видимый";
            c1.MovingHorizon(1); c1.MovingVertical(1);
            Console.WriteLine(c1.Area());
            c1.Print();

            Rectangle r1 = new Rectangle() { Raight_Upper = p1, Left_Lower = p4, Raight_Lower = p2, Left_Upper = p3 };
            Console.WriteLine(r1.Area());
            r1.Color = "синий"; r1.Status = "видимый";
            r1.MovingHorizon(1);
            r1.MovingVertical(1);
            r1.Print();
        }
    }
}
