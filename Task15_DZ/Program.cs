// 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели:");

int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
    Console.WriteLine($"{day} -> нет");
}
else if (day == 2)
{
    Console.WriteLine($"{day} -> нет");
}
else if (day == 3)
{
    Console.WriteLine($"{day} -> нет");
}
else if (day == 4)
{
    Console.WriteLine($"{day} -> нет");
}
else if (day == 5)
{
    Console.WriteLine($"{day} -> нет");
}
else if (day == 6)
{
    Console.WriteLine($"{day} -> да");
}
else if (day == 7)
{
    Console.WriteLine($"{day} -> да");
}
else
{
    Console.WriteLine("Некоректный ввод");
}

