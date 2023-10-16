// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int UserNumber(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumNaturalNumbers(int m, int n)
{
   if (m > n)
    {
        return n + SumNaturalNumbers(m, n + 1);
    }
    else if (m < n)
    {
        return n + SumNaturalNumbers(m, n - 1);
    }
    else return n ;
}

int m = UserNumber("Enter digit m: ");
int n = UserNumber("Enter digit n: ");
int summa = SumNaturalNumbers(m, n);
Console.WriteLine(summa);