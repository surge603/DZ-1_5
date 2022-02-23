// Задача 34: Написать программу для замены элементов массива на противоположные.

Console.Clear();
int[] arr = new int[10];
Console.WriteLine("Исходний массив:");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-100, 100);
    Console.Write(arr[i]+" ");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Новый массив:");

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = -arr[i];
    Console.Write(arr[i]+" ");
}
Console.WriteLine();
