// 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number *= -1;
if (number >= 100 && number <= 999)
{
    int digit = number / 10;
    int secondNumber = digit % 10;
    Console.Write($"Вторая цифра числа : {secondNumber}");

}
else Console.WriteLine("Ошибка ввода!!!");



