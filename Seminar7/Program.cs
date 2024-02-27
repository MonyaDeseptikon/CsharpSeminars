Main2(); //Для запуска одной из задач нужно вписать её номер

/*Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.*/
void Main1()
{
    int[] borders = readLine("Введите любые целые два числа M и N через пробел"); //Предполагается , что пользователь может ввести и отрициательные чила, и ноль
    Console.WriteLine("Натуральные числа в промежутке от M до N");// Предполагается строгий порядок выведения на экран от M до N, даже если M больше чем N 
    bool IncrDecr;
    if (borders[0] < borders[1])
        IncrDecr = true;
    else
        IncrDecr = false;
    printNumbers(borders[0], borders[1], IncrDecr);

}

/*Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.*/
void Main2()
{
    int[] numbers = readLine("Введите два целых неотрицательных числа m и n через пробел");
    Console.WriteLine(calcAckerman(numbers[0], numbers[1]));
}

/*Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.*/
void Main3()
{
    int[] arraySize = readLine("Введите размер массива"); // Пользователь должен ввести положительное целое число
    int[] array = new int[arraySize[0]];
    Console.WriteLine("Созданный массив");
    printArray(array);
}

int calcAckerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return calcAckerman(m - 1, 1);
    else
        return calcAckerman(m - 1, calcAckerman(m, n - 1));
}

void printNumbers(int M, int N, bool myIncrDecr)
{

    if (M > 0)
        Console.Write(M + " ");
    if (M == N)
        return;
    if (myIncrDecr == true)
        printNumbers(M + 1, N, myIncrDecr);
    else
        printNumbers(M - 1, N, myIncrDecr);

}


void printArray(int[] myArray, int count = 0)
{
    if (count == myArray.Length)
    {
        Console.WriteLine();
        Console.WriteLine("Массив в обратном порядке");
        return;
    }

    Random random = new Random();
    myArray[count] = random.Next(1, 100);
    Console.Write(myArray[count] + " ");
    printArray(myArray, count + 1);
    Console.Write(myArray[count] + " ");
}


int[] readLine(string msg = "")
{
    Console.WriteLine(msg);
    string? myString = Console.ReadLine();
    string[] myArray = myString!.Split(" ");
    return Array.ConvertAll(myArray, int.Parse);
}
