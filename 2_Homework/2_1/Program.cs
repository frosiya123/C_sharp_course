//  Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int TakeNum(int num)
 { 
    return num / 10 % 10;
 } 
 Console.WriteLine(TakeNum(678)); 
 Console.WriteLine(TakeNum(456));  

 





