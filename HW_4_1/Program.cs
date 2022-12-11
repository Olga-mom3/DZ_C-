//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine (" Введите  первое число (A): ");
int numA = int.Parse (Console.ReadLine());

Console.WriteLine(" Введите  второе число (B) : ");
int NumB = int.Parse (Console.ReadLine());

int pow = 1;

for ( int i =1 ;i<=NumB ; i++ )
{
   pow = pow*numA ;
}

Console.WriteLine ($" число А в степени В =  {pow}" );