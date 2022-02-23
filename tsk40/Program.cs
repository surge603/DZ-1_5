// Задача 40: В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.

Console.Clear();
double[] arr = new double[15];
Console.WriteLine("Исходный массив вещественных чисел:");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Math.Sqrt(new Random().Next(0, 1000)); // Генерим по-настоящему вещественные числа. Всё по хардкору.
    Console.Write(arr[i] + " ");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Разница между минимальным и максимальным элементами массива:");
Console.WriteLine($"{FindMin(false)} - {FindMin(true)} = {FindMin(false)-FindMin(true)}");
Console.WriteLine();

double FindMin(bool min) // В зависимости от заданного параментра min возвращает минимальное, либо максимальное значение массива
{
    double result = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min && arr[i]<result)
            result = arr[i];
        else if (!min && arr[i]>result)
            result = arr[i];
    }
    return result;
}
