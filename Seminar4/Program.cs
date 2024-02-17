// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

using System;

public class Answer
{
    static void CountEven()
    {
        int ArraySize = Convert.ToInt32(read_line("Введите размер массива"));
        int minRange = 100;
        int maxRange = 999;
        int[] myArray = CreateArray(ArraySize, minRange, maxRange); //
        Console.WriteLine(String.Join(", ", myArray));
        int count = 0;
        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] % 2 == 0)
                count += 1;
        }
        Console.WriteLine($"Количество четных чисел в массиве {count}");

    }


    static void ArrayReverse()
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

    static void NeverEnding()
    {
        //string sborka_stroki = null;
        Console.WriteLine("Вводите целое число с дох пор , пока сумма цифр числа не будет чётная. Или введите ‘q’ для выхода из программы");

        while (true)
        {
            string line = read_line("Введите целое число или q");
            if (line[0] == 'q')
                return;
            if (Convert.ToDouble(line) % 1 != 0)
            {
                Console.WriteLine("Вы ввели не целое число");
                continue;
            }
            if (FindSumDigit(line) % 2 == 0)
            {
                Console.WriteLine("Сумма цифр - четное число");
                return;
            }
        }



    }

    //Блок вспомогательных функций

    static int[] CreateArray(int array_size, int min_range, int max_range)
    {
        Random random = new Random();
        int[] array = new int[array_size];
        for (int i = 0; i < array_size; i++)
        {
            array[i] = random.Next(min_range, max_range + 1);
        }
        return array;
    }
    static string read_line(string msg)
    {
        Console.WriteLine(msg);
        return Console.ReadLine();
    }



    static int FindSumDigit(string line)
    {
        int number = Convert.ToInt32(line);
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
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
            while (number > 3 || number < 1)
            {
                
                Console.WriteLine("Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.");
                Console.WriteLine("Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
                Console.WriteLine("Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)");
                number = Convert.ToInt32(read_line("Введите номер домашнего задания от одного до трех "));
            }
        }

        switch (number)
        {
            case 1:
                NeverEnding();
                break;

            case 2:
                CountEven();
                break;

            case 3:
                ArrayReverse();
                break;

            default:
                break;
        }
    }
}

