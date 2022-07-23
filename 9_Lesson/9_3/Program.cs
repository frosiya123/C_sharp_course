//  Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int Number(int num){
    if(num == 0) return 0;
    return Number(num / 10) + num %10;
}
Console.WriteLine(Number(123));

