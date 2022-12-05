//  Программа, которая принимает на вход два числа и выдает 
// какое из них больше
// a=5 ; b=7 -> max = 7
// a=2 ; b=10 -> max = 10
// a=-9 ; b=-3 -> max = -3

Console.WriteLine ("Введите первое чисо : ");
string number1 = Console.ReadLine();
int num1 = Convert.ToInt32(number1);

Console.WriteLine ("Введите второе чисо : ");
string number2 = Console.ReadLine();
int num2 = Convert.ToInt32(number2);

 if (num1 > num2)
 {
 Console.WriteLine ($"Максимальное число: {number1}");
 }
 else
 {
Console.WriteLine ($"Максимальное число: {number2}");
 }
 if (num1 == num2)
 {
Console.WriteLine (" числа равны ");
 }