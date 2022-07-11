// 1. Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины. 
void Triangle (int numA,int numB, int numC)
{
     if(numA + numB > numC && numA + numC > numB && numB + numC > numA)
     Console.WriteLine("Треугольник существует!");
     else Console.WriteLine("Нет!"); 
} 
Triangle(1, 2, 3); 