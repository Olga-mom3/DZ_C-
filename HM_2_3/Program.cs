// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine(" Введите число,  соответствующее дню недели  :");
string dayNumber = Console.ReadLine();
int dayWeek = Convert.ToInt32(dayNumber);

if (dayWeek == 1)
{
    Console.WriteLine(" Понедельник - НЕТ (не выходной)");
}
else if (dayWeek == 2)
{
    Console.WriteLine(" Вторник - НЕТ (не выходной)");
}
else if (dayWeek == 3)
{
    Console.WriteLine(" Среда - НЕТ (не выходной)");
}
else if (dayWeek == 4)
{
    Console.WriteLine("Четверг - НЕТ (не выходной)");
}
else if (dayWeek == 5)
{
    Console.WriteLine(" Пятница - НЕТ (не выходной)");
}
else if (dayWeek == 6)
{
    Console.WriteLine(" Суббота - ДА ( выходной )");
}
else if (dayWeek == 7)
{
    Console.WriteLine("Воскресенье - ДА (выходной)");
}
 else 
 Console.WriteLine("Введенное число не соответствует дню недели");




// Switch (  на семинаре )
//Console.WriteLine(" Введите число,  соответствующее дню недели  :");
//int dayWeek = Convert.ToInt32( Console.ReadLine());

//switch  (dayWeek) //  четкое сравнение
//{
//case 1 :          //  case открывается : и заканчивается  break;
  //  Console.WriteLine ($" Понедельник - нет " ) ;
   //break ;       
//case 2 :          //  case открывается : и заканчивается  break;
  //  Console.WriteLine ($"  Вторник - нет " ) ;
   //break ;   
//case 7 :          //  case открывается : и заканчивается  break;
  //  Console.WriteLine ($" Воскресенье - да " ) ;
   //break ;  
//default :    // else
//Console.WriteLine ($"  не корректно введено число" ) ;
 //break;
//}