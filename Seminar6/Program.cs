/*Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.*/
using System;
using System.Linq;

Main4();

void Main1()
{
    int CountRow = 3;
    int CountCol = 4;
    char[,] Array = generateArray2dim(CountRow, CountCol);
    PrintArray(Array);
    Console.Write(arrayToString(Array));
}

/*Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.*/
void Main2()
{
    int CountRow = 3;
    int CountCol = 4;
    char[,] Array = generateArray2dim(CountRow, CountCol);
    PrintArray(Array);
    string myString = arrayToString(Array);
    Console.WriteLine(myString);
    Console.WriteLine(myString.ToLower());
}

/*Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.*/
void Main3()
{
    string isPalind = readLine("Введите произвольную строку");
    for (int i = 0; i < isPalind.Length / 2; i++)
    {
        if (isPalind[i] == isPalind[isPalind.Length - 1 - i])
            continue;
        else
        {
            Console.WriteLine("Строка не палиндром");
            return;
        }
    }
    Console.WriteLine("Строка является палиндромом");
}

/*Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.*/
void Main4()
{
    string phrase = readLine("Введите произвольную фразу, где слова разделены пробелами");

    string[] myArray = phrase.Split(" ");
    string temp = "";
    for (int i = 0; i < myArray.Length / 2; i++)
    {
        temp = myArray[i];
        myArray[i] = myArray[myArray.Length - 1 - i];
        myArray[myArray.Length - 1 - i] = temp;
    }
    Console.WriteLine(String.Join(" ", myArray));
}


void PrintArray(char[,] array)
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
char[,] generateArray2dim(int countRow, int countCol)
{
    char[,] array = new char[countRow, countCol];
    var rand = new Random();
    for (int i = 0; i < countRow; i++)
    {

        for (int j = 0; j < countCol; j++)
        {
            if (i == rand.Next(0, countRow) || j == rand.Next(0, countCol))
                array[i, j] = (char)rand.Next('a', 'z');

            else
                array[i, j] = (char)rand.Next('A', 'Z');
        }

    }
    return array;

}

string arrayToString(char[,] array)
{
    string myString = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            myString += array[i, j];
        }

    }
    return myString;
}

string readLine(string msg = "")
{
    Console.WriteLine(msg);
    string? myString = Console.ReadLine();
    return myString!;
}
