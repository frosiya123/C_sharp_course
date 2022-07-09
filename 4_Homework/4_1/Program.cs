//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Numb(int numA, int numB)

{
    int res = numA;
    for (int i = 2; i <= numB; i++)
    {
    res *= numA;
    }
    return res;
}

Console.WriteLine(Numb(3,5));

