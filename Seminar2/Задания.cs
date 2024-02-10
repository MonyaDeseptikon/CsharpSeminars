// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

using System;
public class Answer
{
    static void Opred_kratn()
    {
        Console.WriteLine("Определяем кратно ли число 7 и 23");
        Console.WriteLine("Введите число для проверки 7 и 23");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 7 == 0 && a % 23 == 0)
        {
            Console.WriteLine("Число кратно 7 и 23");
        }
        else
        {
            Console.WriteLine("Число НЕ кратно 7 и 23");
        }
    }

    static void Opred_plosk()
    {
        Console.WriteLine("Определяем в какой плоскости находятся кородинаты X,Y");
        Console.Write("Введите значение точки X: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение точки Y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        if (x == 0 || y == 0)
        {
            Console.Write("Введение нуля недопустимо");
        }
        else
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Правая верхняя четверть");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("Левая верхняя четверть");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("Левая нижняя четверть");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("Правая нижняя четверть");
            }
        }
    }
    static void Opred_max_digit()
    {
        Console.WriteLine("Определяем наибольшую цифру двузначного числа");
        Console.WriteLine("Введите число для проверки от 10 до 99 (включительно)");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a / 10 == a % 10)
        {
            Console.WriteLine("Цифры равны");
        }
        else
        {
            if (a / 10 > a % 10)
            {
                Console.WriteLine("Первая цифра числа больше");
            }
            else
            {
                Console.WriteLine("Вторая цифра числа больше");
            }
        }
    }

    static void Cifry_chisla()
    {
        string sborka_stroki = null;
        Console.WriteLine("Выводим через запятую все цифры числа");
        Console.WriteLine("Введите натуральное число");
        string a = Console.ReadLine();
        if (Convert.ToDouble(a) % 1 != 0 || Convert.ToDouble(a) < 1)
        {
            Console.WriteLine("Вы ввели не натуральное число");
        }
        else
        {
            int b = Convert.ToInt32(a);
            while (b != 0)
            {
                if (b < 10)
                {
                    sborka_stroki = Convert.ToString(b % 10 + ",") + sborka_stroki;
                    Console.Write(sborka_stroki);

                }
                else
                {
                    if (b == Convert.ToInt32(a))
                    {
                        sborka_stroki = Convert.ToString(b % 10) + sborka_stroki;
                    }
                    else
                    {
                        sborka_stroki = Convert.ToString(b % 10 + ",") + sborka_stroki;
                    }
                }
                b = b / 10;
            }
        }
    }
    static public void Main(string[] args)
    {
        int number = 0;
        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            while (number > 4 || number < 1)
            {
                Console.Write("Введите номер домашнего задания от одного до четырех ");
                number = Convert.ToInt32(Console.ReadLine());
            }
        }

        switch (number)
        {
            case 1:
                Opred_kratn();
                break;

            case 2:
                Opred_plosk();
                break;

            case 3:
                Opred_max_digit();
                break;
            case 4:
                Cifry_chisla();
                break;

            default:
                break;
        }
    }
}
