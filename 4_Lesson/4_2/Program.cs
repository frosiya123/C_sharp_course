// 1. Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе. 

int CountNum(int num) 
{ 
    string result = num.ToString(); 
    return result.Length; 
} 
Console.WriteLine(CountNum(456)); 