/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
Console.WriteLine();
Console.WriteLine("Исходный массив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 100);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < m; i++)
{

    for (int j = 0; j < n; j++)
    {
        int maximum = array[i, j];
        for (int k = j; k < n; k++)
        {
            if (array[i, k] > maximum)
            {
                maximum = array[i, k];
                array[i, k] = array[i, j];
                array[i, j] = maximum;

            }
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Упорядоченный массив:");
for (int i = 0; i < m; i++)
{
    int minimal = array[i, 0];
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}