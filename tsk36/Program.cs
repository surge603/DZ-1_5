// Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел.

Console.Clear();
int[] arr = new int[30];
Console.WriteLine("Исходный массив:");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 1000);
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
Console.WriteLine();

int Count(int[] array, bool even)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (even && array[i] / 2 * 2 == array[i])
            sum++;
        else if ((!even && array[i] / 2 * 2 != array[i]))
            sum++;

    }
    return sum;
}
Console.WriteLine($"Количество четных элементов: {Count(arr, true)}");
Console.WriteLine($"Количество нечетных элементов: {Count(arr, false)}");
Console.WriteLine();
