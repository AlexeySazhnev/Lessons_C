// 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2

int[] RandomArray(int arrLength)
{
    int[] array = new int[arrLength];
    Random rand = new Random();
    for (int i = 0; i < arrLength; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] array)
{
    int count = 0;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            if (array[i] % 2 == 0) count += 1;
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.WriteLine($"{array[i]}] -> {count}");
        }
    }
}
int[] arr = RandomArray(4);
PrintArray(arr);