﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {

        enum Operation
        {
            Сложение, Вычитание, Умножение, Деление
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine($"Введите значение переменной A =  ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите значение переменной B =  ");
            int b = Convert.ToInt32(Console.ReadLine());


            while (true)
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("0 - Сложение");
                Console.WriteLine("1 - Вычитание");
                Console.WriteLine("2 - Умножение");
                Console.WriteLine("3 - Деление");

                int operation = Convert.ToInt32(Console.ReadLine());
                switch ((Operation)operation)
                {
                    case Operation.Сложение:
                        Console.WriteLine($"Результат сложения: {a + b}");
                        break;
                    case Operation.Вычитание:
                        Console.WriteLine($"Результат вычитания: {a - b}");
                        break;
                    case Operation.Умножение:
                        Console.WriteLine($"Результат умножения: {a * b}");
                        break;
                    case Operation.Деление:
                        Console.WriteLine($"Результат деления: {a / b}");
                        break;
                    default:
                        Console.WriteLine($"Попробуйте еще раз");
                        break;

                }

                Console.ReadKey();
            }
        }
    }
}
