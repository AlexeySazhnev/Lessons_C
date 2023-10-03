// 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементов массива.

// [3 7 22 2 78] -> 76

double[] CreateArrarRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }

    return arr;
}

double MaxElement(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }

    return max;
}

double MinElement(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }

    return min;
}

void DiffMaxandMin(double[] arr)
{
    double max = MaxElement(arr);
    double min = MinElement(arr);
    double result = max - min;

    Console.Write($" -> {result:F1}");
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F1}: ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.Write("]");
}

double[] array = CreateArrarRndDouble(5, -99, 100);
PrintArrayDouble(array);
DiffMaxandMin(array);


