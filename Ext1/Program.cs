using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 1.Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:

            а) используя склеивание;
            б) используя форматированный вывод;
            в) используя вывод со знаком $.
            */

            Console.WriteLine("Введите свое имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите свой возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите свой рост");
            int growth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите свой вес");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Вас зовут: {name} {surname}, ваш возраст: {age}, ваш рост: {growth}, ваш вес: {height}");
        }
    }
}
