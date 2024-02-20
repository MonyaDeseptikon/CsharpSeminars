using System;

/*ЗАДАЧА1
//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

    // Поиск элемента по позициям
    public static int FindElementByPosition(int[,] array, int x, int y)
    {
        //Напишите свое решение здесь
        return array[(x - 1), (y - 1)];
    }

    // Проверка позиций на вхождение в массив
    public static bool ValidatePosition(int[,] array, int x, int y)
    {
        //Напишите свое решение здесь
        if (array.GetLength(0) < x)
        {
            Console.WriteLine("Позиция по рядам выходит за пределы массива");
            return true;
        }
        if (array.GetLength(1) < y)
        {
            Console.WriteLine("Позиция по колонкам выходит за пределы массива");
            return true;
        }
        else
            return false;
    }

    public static void PrintResult(int[,] numbers, int x, int y)
    {
        //Напишите свое решение здесь
        if (ValidatePosition(numbers, x, y))
            return;

        else
        {
            Console.WriteLine(FindElementByPosition(numbers, x, y));
        }
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] array;

        int x, y;

        if (args.Length >= 3)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            array = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        array[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }

            // Парсинг x и y из аргументов
            if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
            {
                // Теперь у вас есть двумерный массив "array" и координаты x и y
                UserInputToCompileForTest.PrintResult(array, x, y);
            }
            else
            {
                Console.WriteLine("Error parsing x or y to an integer.");
            }
        }
        else
        {

            // Если аргументов на входе нет, используем примерный массив
            array = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
            x = 2;
            y = 2;

            UserInputToCompileForTest.PrintResult(array, x, y);

        }
    }
}
*/

/*ЗАДАЧА2*/
//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    // Печать массива
    public static void PrintArray(int[,] array)
    {
        //Напишите свое решение здесь
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Обмен первой с последней строкой
    public static int[,] SwapFirstLastRows(int[,] array)
    {
        //Напишите свое решение здесь
        int temp = 0;
        int lastRow = array.GetLength(0) - 1;
        //Console.WriteLine(array.GetLength(1));
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = array[0, j];
            array[0, j] = array[lastRow, j];
            array[lastRow, j] = temp;
        }
        return array;


    }

    // Обмен элементами массива
    public static void SwapItems(int[,] array, int i)
    {
        //Напишите свое решение здесь
    }

    public static void PrintResult(int[,] numbers)
    {
        //Напишите свое решение здесь
        //PrintArray(numbers);
        SwapFirstLastRows(numbers);
        //Console.WriteLine();
        PrintArray(numbers);

    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            numbers = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}