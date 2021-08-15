using System;

namespace Lesson2Ext2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Написать метод подсчета количества цифр числа.

            Console.Write("Введите число : ");
            int num = int.Parse(Console.ReadLine());
            int result = CountNumber(ref num);
            Console.WriteLine("Количество цифр введенного числа : {0}", result);
            Console.ReadKey();

        }

        private static int CountNumber(ref int num)
        {
            int i = 0;
            while (num > 0)
            {
                i++;
                num /= 10;
            }

            return i;
        }
    }
}
