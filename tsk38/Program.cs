// Задача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции.

Console.Clear();
int[] arr = new int[15];
Console.WriteLine("Исходный массив:");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 100);
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Сумма нечетных элементов массива:");

int sum = 0;
for (int i = 0; i < arr.Length; i += 2)
{
    if (i != 0)
        Console.Write(" + ");
    Console.Write(arr[i]);
    sum += arr[i];
}
Console.WriteLine($" = {sum}");
Console.WriteLine();
