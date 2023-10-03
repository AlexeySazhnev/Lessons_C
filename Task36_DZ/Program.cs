// 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] RandomArray(int arrLength)
{
    int[] array = new int[arrLength];
    Random rand = new Random();
    for (int i = 0; i < arrLength; i++)
    {
        array[i] = rand.Next(-100, 100);
    }
    return array;
}
void PrintArray(int[] array)
{
    int sum = 0;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            if (i % 2 != 0) sum += array[i];
            Console.Write($"{array[i]}, ");
        }
        else
        {
            sum += array[i];
            Console.WriteLine($"{array[i]}] -> {sum}");
        }
    }
}
int[] arr = RandomArray(4);
PrintArray(arr);