﻿using System;

namespace Ext4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую переменную");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую переменную");
            int two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Значение до обмена первой переменной: {one} ");
            Console.WriteLine($"Значение до обмена второй переменной: {two} ");
            int exchange = one;
            one = two;
            two = exchange; 

            Console.WriteLine($"Значение после обмена первой переменной: {one} ");
            Console.WriteLine($"Значение после обмена второй переменной: {two} ");

        }
    }
}
