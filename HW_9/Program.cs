// 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine(" Задача 64 ");
Console.Write("Введите  число  N : ");
int number = int.Parse(Console.ReadLine());

int NumbersRec(int number)
{
    Console.Write($"{number},");
    if (number <= 2) return 1;
    else return NumbersRec(number - 1);
}
Console.Write(NumbersRec(number));

//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.WriteLine();
Console.WriteLine(" Задача 66 ");
Console.Write("Введите  число  M : ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите  число  N : ");
int n = int.Parse(Console.ReadLine());

int SumRec (int n, int m)
{
if (n>m) return 0;
else return n + SumRec(n+1, m);
}
Console.Write($"Сумма чисел равна {SumRec(m,n)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine();
Console.WriteLine(" Задача 68 ");

Console.Write("Введите  число  M : ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Введите  число  N : ");
int numN = int.Parse(Console.ReadLine());

int A(int numN, int numM)
{
    if (numN == 0)
        return numM + 1;
    else
      if ((numN != 0) && (numM == 0))
        return A(numN - 1, 1);
    else
        return A(numN - 1, A(numN, numM - 1));
}
Console.Write($" функция Аккермана = {A(numM, numN)}");
