//70.Создать интерфейс ICipher, который определяет методы поддержки шифрования строк. 
//В интерфейсе объявляются два метода encode() и decode(), которые используются для шифрования и дешифрования строк, 
//соответственно. 
//Создать класс ACipher, реализующий интерфейс ICipher. Класс шифрует строку посредством сдвига каждого символа
//на следующий за ним в алфавите. Например, в результате такого сдвига буква A становится буквой B.
//Создать класс BCipher, реализующий интерфейс ICipher. Класс шифрует строку, выполняя замену каждой буквы, 
//стоящей в алфавите на i-й позиции, на букву того же регистра, расположенную в алфавите на i-й позиции с конца 
//алфавита. Например, в результате такого сдвига буква B становится буквой Y. Обрабатывать только буквы, 
//другие символы не шифровать.
//	Написать программу, демонстрирующую функционирование классов.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("class ACipher");
            ACipher r = new ACipher() { S = "БВГ" };
            Console.WriteLine(r.encode());
            ACipher r2 = new ACipher() { S = r.encode() }; //ВГД
            Console.WriteLine(r2.decode());

            
            Console.WriteLine("class BCipher");
            BCipher t = new BCipher() { S = "A" };
            Console.WriteLine(t.encode());
            //кодируем
            BCipher c = new BCipher() { S = t.encode() }; // Z
            Console.WriteLine(c.decode());//получили значение до кодирования (A)
            
        }
        
    }
}
