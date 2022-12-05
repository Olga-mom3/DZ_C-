//  Программа, которая на вход принимает число и 
// на выход выдает является ли число четным ( делится на два без остатка)
// 4 -> да
// -3 -> нет 
// 7 -> нет 

Console.WriteLine ("Введите число");
string number = Console.ReadLine();
int num = Convert.ToInt32 (number);
if (num % 2 == 0)
Console.WriteLine ("Четное число");
 else  
 Console.WriteLine (" Нечетное число");