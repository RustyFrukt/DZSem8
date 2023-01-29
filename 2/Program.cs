/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Write("Задайте размер массива: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[n, n];
Console.WriteLine();
Console.WriteLine("Исходный массив:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 100);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

int minimum = (int)Math.Pow(2, 16);
int row = 0;
for (int i = 0; i < n; i++)
{
    int summ = 0;
    for (int j = 0; j < n; j++)
    {
        summ += array[i, j];
    }
    if (summ < minimum)
    {
        minimum = summ;
        row = i;
    }
}
Console.WriteLine();
Console.WriteLine("Строка с наименьшей суммой: " + row);