using System;

namespace Ext3
{
    class Program
    {
        static void Main(string[] args)
        {
            // а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
            // о формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
            // Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            Console.WriteLine("Введите x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double formula = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double result = System.Math.Round(formula, 2);
            Console.WriteLine($"расстояние между точками с координатами x1, y1 и x2,y: {result} ");

        }
    }
}
