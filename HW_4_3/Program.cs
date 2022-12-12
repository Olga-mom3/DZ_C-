// Задача 29: Напишите программу, которая  на вход принимает (вводит пользователь)
//массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите 8 чисел");
int[] arr = new int[8]; 

for (int i=0; i<8; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
Console.WriteLine($"[{string.Join(",", arr)}]");


/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

int[] array = GetRandomArray(8, 0, 100);

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}
Console.WriteLine($"[{String.Join(",", array)}]"); */

