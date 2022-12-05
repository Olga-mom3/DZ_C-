//  Программа, которая на вход принимает три числа и выдает максимальное из них
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine ("Введите первое число");
string enterNum1 = Console.ReadLine();
int num1 = Convert.ToInt32 (enterNum1);
Console.WriteLine ("Введите второе число");
string enterNum2 = Console.ReadLine();
int num2 = Convert.ToInt32 (enterNum2);
Console.WriteLine ("Введите третье число");
string enterNum3 = Console.ReadLine();
int num3 = Convert.ToInt32 (enterNum3);

 int max = num1 ;

 if (num1 > max) 
 {
    max = num1; 
    }
 if (num2 > max) 
 {
    max = num2 ;
 }
 if (num3 > max) 
 {
    max = num3 ;
 }

 Console.WriteLine ($" Максимальное число : { max }");
