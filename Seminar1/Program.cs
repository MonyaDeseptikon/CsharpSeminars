using System;

//ЗАДАЧА 1
/*public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
      if (firstNumber == secondNumber)
      {
        Console.WriteLine("Числа равны");
      }
      else
      {
        if (firstNumber > secondNumber)
        {
          Console.WriteLine("Первое число больше");
        }
        else {Console.WriteLine("Второе число больше");}
      }
    

    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 5;
            secondNumber = 5;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}*/

//ЗАДАЧА 2
/*public class Answer {
    
  static int FindMax(int a, int b, int c)
    {
      // Введите свое решение ниже
        if (a>=b && a>=c) {return a;}
        if (b>=a && b>=c) {return b;}
        if (c>=a && c>=a) {return c;}
        else {return a;} //Компилятор так хочет
    }

  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
           a = int.Parse(args[0]);
           b = int.Parse(args[1]);
           c = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           a = 3;
           b = 0999999999;
           c = -1;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}*/

//ЗАДАЧА 3
/*class Answer {
    static void CheckIfEven(int number)
    {
      // Введите свое решение ниже
        if (number % 2 == 0) {Console.Write("четное");}
        else {Console.Write("нечетное");}

    }
  

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 5;
        }

        // Не удаляйте строки ниже
        CheckIfEven(number);
    }
}*/

//ЗАДАЧА 4 
/*public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
       if (number < 1) {System.Console.WriteLine("Введите корректное число");}
       else { 
        for (int i =1; i<=number; i++) 
        {
            if (i%2==0) {System.Console.Write(i+" ");}
        }
       }
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}
*/

//Math.Pow Математический класс с множеством методов

Console.WriteLine ("Введите два числа");
int firstNumber = Convert.ToInt32(Console.ReadLine ());
int secondNumber = Convert.ToInt32(Console.ReadLine ());
if (firstNumber%secondNumber==0)
{
    Console.WriteLine("Первое число кратно второму");
}
else 
{
    Console.WriteLine("Первое число НЕкратно второму");  
}