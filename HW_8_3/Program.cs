// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента. Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] array = new int[2, 2, 2];
int length0 = array.GetLength(0);
int length1 = array.GetLength(1);
int length2 = array.GetLength(2);

int[,,] newArray = GetArray(array);

int[,,] GetArray(int[,,] array) // заполняем массив
{
    for (int ind1 = 0; ind1 < length0; ind1++)
    {
        for (int ind2 = 0; ind2 < length1; ind2++)
        {
            for (int ind3 = 0; ind3 < length2; ind3++)
            {
                array[ind1, ind2, ind3] = new Random().Next(0, 9);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] inArray) // вывод на печать
{
    for (int ind1 = 0; ind1 < length0; ind1++)
    {
        for (int ind2 = 0; ind2 < length1; ind2++)
        {
            for (int ind3 = 0; ind3 < length2; ind3++)
            {
                Console.Write($"{inArray[ind1, ind2, ind3]}({ind1},{ind2},{ind3}) ");
            }
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Исходный массив");
PrintArray(newArray);

Console.WriteLine();