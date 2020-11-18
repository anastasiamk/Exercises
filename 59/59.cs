/*
 * 59. Создать класс «Преподаватель». Строковые поля ФИО, предмет. 
 * Методы: конструктор с параметрами, методы изменения названия предмета, 
 * метод ToString() для вывода ФИО и предмета, метод «оценить студента», 
 * принимающего в параметры студента (его фамилию), и работающего следующим образом: 
 * генерируется случайное число от 2 до 5, выводится строка: «преподаватель ИМЯпреподавателя оценил 
 * студента с именем ИМЯстудента по предмету ИМЯпредмета на оценку ОЦЕНКА». 
 * Все слова, написанные капслоком, должны быть заменены соответствующими значениями. 
 * ОЦЕНКА должна принимать значение «отлично», «хорошо», «удовлетворительно» или «неудовлетворительно» 
 * (в зависимости от значения случайного числа).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59
{
    class Teacher
    {
        public string fio, subject;

        public Teacher(string fio, string subject) { this.fio = fio; this.subject = subject; }
        public Teacher() : this(null, null) { }
        //public Teacher(string fio) { this.fio = fio; }
        public Teacher(string subject) { this.subject = subject; }


        public void ChangeSubject(string new_subject)
        {
           subject = new_subject;
        }
        public override string ToString()
        {
            return $"ФИО учителя: {this.fio}, предмет: {this.subject}";

        }

        public void RateStudent(string fio)
        {
            Random r = new Random();
            int o = r.Next(2, 5);
            string res = null;
            if (o == 2) { res = "неудовлетворительно"; }
            if (o == 3) { res = "удовлетворительно";  }
            if (o == 4) { res = "хорошо"; }
            if (o == 5) { res = "отлично"; }
            Console.WriteLine($"преподаватель {this.fio} оценил студента с именем {fio} по предмету {this.subject} на оценку {res}");


        }


    }

    class Program

    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher("Васильков Игорь Петрович", "биология");
            t1.ChangeSubject("математика");
            t1.RateStudent("Иван");
            
            
        }
    }
}
