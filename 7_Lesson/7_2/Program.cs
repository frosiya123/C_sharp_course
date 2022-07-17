// Задайте двумерный массив размера m на n, каждый
//элемент в массиве находится по формуле: Aₙₙ = m+n.
//Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

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

int[,] MassNums(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {   
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = i + j;
        }        
    }
    return arr;
}


Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] arr_1 = MassNums(row, column);
Print(arr_1);
