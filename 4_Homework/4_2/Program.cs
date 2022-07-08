//Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int getNumber = int.Parse(Console.ReadLine());
Console.WriteLine(SumNumber(getNumber));
int SumNumber(int Number)
{
    int n_sum = 0;

    while (Number > 0)
    {
        n_sum += Number  % 10;
        Number /= 10;
    }
    return n_sum;
}

