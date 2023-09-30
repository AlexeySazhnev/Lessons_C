// 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите целое число:");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
    if (num < 0) num *= -1;
    int sum = 0;

    for (int i = 1; num % 10 < 1; i++)
    {
        int digit = num % 10;
        sum = sum + digit;
    }
    return sum;
}

int sumDigit = SumDigit(num);
Console.Write($"{num} -> {sumDigit}");
