//Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

int day = int.Parse(Console.ReadLine());
if(day < 6)
{
    Console.WriteLine("Пока не выходной");
}
if((day == 6) || (day == 7)) 
{
    Console.WriteLine("Выходной");
}

//else
//{
  //  Console.WriteLine("Пока не выходной");
//}
if(day > 7)
{
    Console.WriteLine("Нет такого дня");
}