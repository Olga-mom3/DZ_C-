//19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет    12821 -> да 23432 -> да

Console.WriteLine ("Ввести 5 значное число: ");
string enternum = Console.ReadLine();
int lenNum = enternum.Length;

if (lenNum == 5)
{
    if (enternum[0] == enternum[4] && enternum [1] == enternum[3])
    {
        Console.WriteLine("Да, палиндром");
    }
    else
        {
        Console.WriteLine("Нет, не палиндром");
        }
}
if (lenNum > 5 )
    { 
    Console.WriteLine(" число не пятизначное");
    }
if (lenNum < 5 )
   { 
   Console.WriteLine(" число не пятизначное");
 }


