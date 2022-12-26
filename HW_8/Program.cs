// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:   В итоге получается вот такой массив:
// 1 4 7 2                    7 4 2 1
// 5 9 2 3                    9 5 3 2
// 8 4 2 4                    8 4 4 2

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(" Задан массив :");

int[,] array = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.Write("Задача №54  ");
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        int max = array[i, j];
        for (int k = j; k < n; k++)
        {
            if (array[i, k] > max)
            {
                max = array[i, k];
                array[i, k] = array[i, j];
                array[i, j] = max;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine(" Упорядоченный от максимума к минимуму массив :");
for (int i = 0; i < m; i++)
{
    int min = array[i, 0];
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}





