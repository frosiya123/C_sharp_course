//Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

//void Number1(int num)
//{
   // if((num / 10000  == num % 10) && (num / 1000 % 10 == num / 10 % 10))
   // {
       
    //    Console.WriteLine(" Это число палиндром");
   // }
        
    //else 
    //{
       // Console.WriteLine(" Это число не палиндром");
   // }
//}
//Number1(14212);
//Number1(12821);
//Number(23432);

//Сначала нужна проверка на то, что это пятизначное число.
//Если оно не пятизначное, то введите пятизначное число
//Если оно пятизначное, то проверка на палиндром
//Вывод 
int Number = int.Parse(Console.ReadLine());
int razr = 10000;
if(Number > 100000 || Number < 10000 )
{
    Console.WriteLine("Введите пятизначное число");
    return;
}

while (Number > 10)
{
   
    int first = Number / razr;
    int last = Number % 10;
     if( first != last )
     {
         Console.WriteLine("Число не является полиндромом");
          break;
     }
     Number = Number - first * razr;
     Number = Number / 10;
     razr = razr / 100;
}
if( Number < 10 )
{
   Console.WriteLine("Число является полиндромом");
}

