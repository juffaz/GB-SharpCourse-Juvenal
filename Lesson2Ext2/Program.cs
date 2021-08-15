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
            CountNumber(ref num);

        }

        private static int CountNumber(ref int num)
        {
            int i = 0;
            while (num > 0)
            {
                i++;
                num /= 10;
            }
            Console.WriteLine("Количество цифр введенного числа : {0}", i);
            Console.ReadKey();
            return 0;
        }
    }
}
