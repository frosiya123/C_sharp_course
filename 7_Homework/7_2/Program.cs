// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение элемента, 
// или указывает что такого элемента нет
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        } 
        Console.WriteLine();       
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {   
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }        
    }
    return arr;
}

string Pos (int [,] array, int numA, int numB){
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    if (numA > row || numA <= 0 || numB > column || numB <= 0)
    return $"[{numA}, {numB}] - такой позиции не существует";
    return $"array [{numA}, {numB}] = {array[numA - 1, numB - 1]} - вот это число";
}


Console.WriteLine("Введите номер строки: ");
int one = int.Parse(Console.ReadLine());

Console.WriteLine("Введите номер столбца: ");
int two = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(3, 4, 1, 100);
Print(arr_1);

Console.WriteLine(Pos(arr_1, one, two));