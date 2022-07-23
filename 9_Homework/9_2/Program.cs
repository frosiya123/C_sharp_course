// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int PowerNumb(int numA, int numB){
    if(numB < numA) return 0;
    return PowerNumb(numA, numB -1) + numB;
}
Console. Write(PowerNumb(1, 15));