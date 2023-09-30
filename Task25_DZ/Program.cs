// 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int numB = Convert.ToInt32(Console.ReadLine());

int Degree(int numA, int numB)
{
    int mult = 1;

    for (int i = 1; i <= numB; i++)
    {
        mult = mult * numA;
    }
    return mult;
}

int result = Degree(numA, numB);
Console.WriteLine($"{numA}, {numB} -> {result}");