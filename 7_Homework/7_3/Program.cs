// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[j, i]} ");
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
void Average(int[,] Array)
{
    int row = Array.GetLength(0);
    int column = Array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        double sum = 0;
        for (int j = 0; j < column; j++)
        {
            sum += Array[i,j];
        }
        Console.WriteLine($"(среднее арифметическе {i} столбца = {sum/column})");
    }
}


Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column, 1, 101);
Print(arr_1);
Average(arr_1);



