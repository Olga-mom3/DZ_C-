// Напишите программу, которая на вход принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine(" Введите число :");
string enterN = Console.ReadLine();
int num = Convert.ToInt32(enterN);

int temp = 1;
while (temp <= num)
{
    if (temp % 2 == 0)
    {
        Console.WriteLine($" Четные числа : {temp}");
    }
    temp++;
}
