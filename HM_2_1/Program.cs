// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine(" Введите число :");
int num = int.Parse (Console.ReadLine ());

int num2 = (num/10) % 10 ;

if (num < 100)
{
    Console.WriteLine (" число не трехзначное" );
}
if (num > 999)
{
  Console.WriteLine (" число не трехзначное" );
}
else 
{
Console.WriteLine ($" {num2}" );
}




