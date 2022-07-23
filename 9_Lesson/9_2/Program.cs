// Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void Numb(int numM, int numN){
    if(numN < numM) return;
    Numb(numM, numN-1);
    Console.Write($"{numN}, ");
}
Numb(1,5);