// 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

using System.Reflection;

public class Answer
{
    static bool IsPalindrome(int number)
    {
        // Введите свое решение ниже

        if (number >= 10000 && number <= 99999)
        {

        int firstDigit = number / 10000;
        int secondDigit = number / 1000 % 10;
        int fourthDigit = number / 10 % 10;
        int lastDigit = number % 10;

        return firstDigit == lastDigit && secondDigit == fourthDigit; 

        }
        else 
        {
            Console.WriteLine("Число не пятизначным");
            return false;
        }


    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 14212;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}