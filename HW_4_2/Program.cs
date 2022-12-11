//  27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11    82 -> 10    9012 -> 12

Console.WriteLine(" Введите число : ");
int enterNum = int.Parse(Console.ReadLine());

int Sum = 0;
int Num1 = 1;
int Num2 = enterNum; 
for (; Num2> 0;)
{
    Num1 = Num2 % 10; 
    Sum = Sum + Num1; 
    Num2= Num2/ 10;  
}
Sum = Sum + Num2; 

Console.WriteLine($" Сумма цифр числа {enterNum} - равна {Sum}");

