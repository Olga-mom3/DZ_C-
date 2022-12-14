//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] GetArray(int size, int minNum, int maxNum)
{
    Console.Write("Заданный массив   ");

    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minNum, maxNum + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
    Console.WriteLine();
}
int[] res = GetArray(5, 100, 999);
Console.WriteLine();

int CountNum(int[] arr)
{
    int count = 0;
    foreach (var item in arr)
    {
        if (item % 2 == 0)
            count++;
    }
    return count;
}
Console.WriteLine($"  Колличество четных элементов = {CountNum(res)}");

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19      [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minNum, int maxNum)
{
    Console.Write("Заданный массив   ");

    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minNum, maxNum);
        Console.Write($" {res[i]} ");
    }
    return res;
    Console.WriteLine();
}
int[] res = GetArray(5, 1, 30);
Console.WriteLine();

int Count(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            sum += array[i];
    }
    return sum;
}
Console.WriteLine($"  Сумма элементов на нечетных позициях = {Count(res)}");



//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int count = 5;
double[] array = new double[count];
int i = 0;

for ( ; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100) + new Random().NextDouble();
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine ();

double result =0;
double min = array[0];
double max = array[0];

for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
    if (array[j] < min)
    {
        min = array[j];
    }
}
Console.WriteLine($"min элемент {min} max элемент {max}");
result = max - min;
Console.WriteLine ();
Console.WriteLine($"Разница {result}"); */