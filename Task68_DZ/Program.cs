// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

// Моё решение :

// int Ack(int n, int m)
// {
//     if (n == 0)
//     {
//         return m + 1;
//     }
//     else if (m == 0)
//     {
//         return Ack(n - 1, 1);
//     }
//     else return Ack(n - 1, Ack(n, m - n));
// }
// Console.WriteLine("Введите число n: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число m: ");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.Write(Ack(numN, numM));

// Хочу быть честным)) отредактировал через GPT,т.к. как работают классы и метод Main не понял :
class Program
{
 
    static int Ack(int n, int m)
    {
        if (n == 0)
        {
            return m + 1;
        }
        else if (m == 0)
        {
            return Ack(n - 1, 1);
        }
        else return Ack(n - 1, Ack(n, m - 1));
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите число n: ");
        int numN = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число m: ");
        int numM = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Ack(numN, numM));
    }
}
