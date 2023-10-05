// 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int GetUserInput()
{

    Console.WriteLine("Введите кол-во М чисел :");
    int size = Convert.ToInt32(Console.ReadLine());

    return size;
}

int[] GetUserInputArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1}-e число :");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintOut(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[^1]}]");
}

int CountPositiveNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] > 0) count++;
    }

    return count;

}

int size = GetUserInput();
int[] array = GetUserInputArray(size);
int count = CountPositiveNum(array);
PrintOut(array);
Console.WriteLine($"-> {count}");
