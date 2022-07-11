// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1. 

void FibNum(int num)
{
    int numA = 0;
    int numB = 1;
    for (int i = 0; i < num; i++){
        Console.Write($"{numA} ");
        (numA, numB) = (numB, numA + numB);
    }
}
FibNum(5);
