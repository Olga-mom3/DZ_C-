// Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// | a11 a12 | * | b11 b12 |= | a11*b11 + a12*b21   a11*b12 + a12*b22 |
// | a21 a22 |   | b21 b22 |  | a21*b11 + a22*b21   a21*b12 + a22*b22 |


int[,] A = GetArray(2, 2, 0, 5); // матрица 2*2
int[,] B = GetArray(2, 2, 0, 5);

Console.WriteLine(" Матрица A : ");
PrintArray(A);
Console.WriteLine(" Матрица B : ");
PrintArray(B);
Console.WriteLine();
Console.WriteLine(" Результат умножения матриц A и B : ");
PrintArray(GetMultiplicationMatrix(A, B));

int[,] GetArray(int m, int n, int min, int max)  //  заполняем рандом. матрицу
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray) // выводим
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($" {inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB) //умножаем матрицы
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;
}
