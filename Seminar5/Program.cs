using System;

/*ЗАДАЧА1
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет: "Позиция по рядам выходит за пределы массива"
или
"Позиция по колонкам выходит за пределы массива"
Позиции в массиве считать от единицы.

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

/*ЗАДАЧА2
//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
*/

/*ЗАДАЧА3
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    /// Вычисление сумм по строкам (на выходе массив с суммами строк)
    public static int[] SumRows(int[,] array)
    {
        //Напишите свое решение здесь
        int[] sumRowArray = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int count = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                count += array[i, j];
            }
            sumRowArray[i] = count;
        }
        return sumRowArray;
    }

    // Получение индекса минимального элемента в одномерном массиве
    public static int MinIndex(int[] array)
    {
        //Напишите свое решение здесь
        int min = array[0];
        int rowNumber = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                rowNumber = i;
            }
        }
        return rowNumber;
    }
    public static void PrintResult(int[,] numbers)
    {
        //Напишите свое решение здесь
        Console.WriteLine(MinIndex(SumRows(numbers)));

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

            numbers = new int[,] {
                {1, 2, 3},
                {1, 1, 0},
                {7, 8, 2},
                {9, 10, 11}
    };
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}
*/


/*ЗАДАЧА4 (факультативная)*/
// Задайте двумерный массив 
// из целых чисел. Напишите программу, которая удалит 
// строку и столбец, на пересечении которых расположен 
// наименьший элемент массива. Под удалением 
// понимается создание нового двумерного массива без 
// строки и столбца
class Program
{
    public static void Main()
    {
        int[,] numbers = new int[,] {
                {1, 2, 3},
                {1, 1, 0},
                {7, 8, 2},
                {9, 10, 11}};
        Program.PrintArray(numbers);
        Console.WriteLine();
        Program.findMinNumber(out int minNumRow, out int minNumCol, numbers);
        Console.WriteLine(minNumRow + "," + minNumCol);
        Program.PrintArray(Program.DelRowColMinNumber(minNumRow, minNumCol, numbers));



    }
    public static void findMinNumber(out int minNumRow, out int minNumCol, int[,] array)
    {
        int min = array[0, 0];
        minNumRow = 0;
        minNumCol = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {

            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                    minNumRow = i;
                    minNumCol = j;
                }
            }

        }

    }

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

    public static int[,] DelRowColMinNumber(int minNumRow, int minNumCol, int[,] numbers)
    {
        int[,] newArray = new int[(numbers.GetLength(0) - 1), (numbers.GetLength(1) - 1)];
        int k = 0;

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            int m = 0;
            if (i == minNumRow)
                continue;
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                if (j == minNumCol)
                    continue;
                newArray[k, m] = numbers[i, j];
                m++;

            }
            k++;
        }
        return newArray;
    }
}