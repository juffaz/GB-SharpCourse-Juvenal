using System;

namespace Ext2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            2. Ввести вес и рост человека. 
            Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

            */

            Console.WriteLine("Введите свой рост");
            double growth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите свой вес");
            double height = Convert.ToDouble(Console.ReadLine());
            double bodyMass = (double)(height / (growth * growth));
            Console.WriteLine($"Ваш индекс массы тела: {bodyMass} ");
        }
    }
}
