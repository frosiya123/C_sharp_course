//Программа, которая принимает на вход трехзначное число и на выходе
//показывает последнюю цифру этого числа

int TakeNum(int num)
 { 
    return num % 10;
 } 
 Console.WriteLine(TakeNum(678)); 
 Console.WriteLine(TakeNum(678565565));  