//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

Console.Write(" Задача 52 : ");
Console.WriteLine();

int[,] array = GetArrayMatrix(rows, columns, 0, 9);

PrintArray(array);

int[,] GetArrayMatrix(int rows, int columns, int minValue = 0, int maxValue = 100)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] Average = new double[columns];
double sum = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Average[j] = (sum + array[i, j]) / (columns);
        sum = sum + array[i, j];
    }
}

void PrintAverage(double[] array)
{
    for (int j = 0; j < rows; j++)
        Console.Write($"{Average[j]} | ");
}
Console.WriteLine();
Console.WriteLine("Среднее арифметическое по столбцам : ");
Console.WriteLine();

PrintAverage(Average);


// Задача 50. Напишите программу, которая на вход принимает значение элемента 
// в двумерном массиве, и возвращает значение и индекс этого элемента ( строка , колонка)
// или же указание, что такого элемента нет.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.WriteLine();
Console.WriteLine();
Console.Write(" Задача 50 : ");
Console.WriteLine();

Console.Write("Введите значение для поиска в массиве: ");
int number = int.Parse(Console.ReadLine());

int indexI = 0;
int indexJ = 0;

 for (int i = 0; i<columns; i++)
 {
     for (int j = 0; j<rows; j++)
    {
     if (array[i,j] == number) 
     {
     indexI = i;
     indexJ = j;
     Console.Write($"число {number} найдено в массиве на позиции ({indexI},{indexJ})");
     Console.WriteLine();
     }
    }
 }

if (indexI == 0 && indexJ ==0)
Console.Write($" число {number} не найдено в массиве");



