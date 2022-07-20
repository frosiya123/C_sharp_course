// Задача 4: Задайте двумерный массив. Введите элемент, и найдите
// первое его вхождение, выведите позиции по горизонтали и
// вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

void PrintIntArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"-{matr[i, j]}- ");

        }
        Console.WriteLine();
    }
}

int[,] FillArrayFunc (int m, int n)
{
    int [,] resultArray = new int [m,n];

    for (int i = 0; i < m; i++)
    {

        for (int j = 0; j < n; j++)
    {
        resultArray[i, j] = new Random().Next(0, 10);
    }
    }

    return resultArray;
}


void FindPosOfNum (int [,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == num)
            {
                Console.WriteLine($"[{i+1}, {j+1}]");
                return;
            }
        }
    }
    Console.WriteLine("не найдено");
}






int [,] matrix = FillArrayFunc(4,4);
PrintIntArray(matrix);
FindPosOfNum(matrix,4);