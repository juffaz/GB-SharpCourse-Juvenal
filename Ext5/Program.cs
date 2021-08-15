using System;

namespace Ext5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            5.
            а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            б) Сделать задание, только вывод организовать в центре экрана.
            */
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите город проживания");
            string city = Console.ReadLine();
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine($"Вас зовут: {name} {surname}, город проживания: {city}");

        }
    }
}
