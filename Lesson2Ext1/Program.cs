using System;

namespace Lesson2Ext1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Написать метод, возвращающий минимальное из трёх чисел.
            */

            Console.WriteLine("Введите x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x3");
            int x3 = Convert.ToInt32(Console.ReadLine());

            MinimalDigital(x1, x2, x3);
        }

        private static void MinimalDigital(int x1, int x2, int x3)
        {
            if (x1 < x2 && x1 < x3)
                Console.WriteLine("x1 минимальное число");
            else if (x2 < x1 && x2 < x3)
                Console.WriteLine("x2 минимальное число ");
            else
                Console.WriteLine("x3 минимальное число ");
        }

    }
}
