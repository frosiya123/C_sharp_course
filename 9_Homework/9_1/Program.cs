// Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"
void Numb(int numM, int numN){
    if(numN < numM) return;
    if (numM % 2 == 0)
         Console.WriteLine($"{numM}, ");
    Numb(numM + 1, numN);
}
Numb(2,4);