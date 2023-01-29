/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.Write("Задайте размер массива: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;
while (temp <= n * n)
{
    array[i, j] = temp;
    if (i <= j + 1 && i + j < n - 1)
        ++j;
    else if (i < j && i + j >= n - 1)
        ++i;
    else if (i >= j && i + j > n - 1)
        --j;
    else
        --i;
    ++temp;
}
for (int c = 0; c < array.GetLength(0); c++)
{
    for (int d = 0; d < array.GetLength(1); d++)
    {
        Console.Write($"{array[c, d]:d2} ");
    }
    Console.WriteLine();
}
Console.WriteLine();