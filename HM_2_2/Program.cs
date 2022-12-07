// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine(" Введите число :");
string enterNum = Console.ReadLine();
int number = enterNum.Length;

if (number < 3)
{
    Console.WriteLine($" Число состоит меньше чем из трех цифр");
}
 else 
 { 
    Console.Write($"третья цифра в числе - ");
    Console.WriteLine(enterNum.Substring(2, 1));
 }
