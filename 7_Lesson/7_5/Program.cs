// Решение в группах задач:
// Задача 2: Задайте двумерный массив. Найдите элементы, у которых
// обе позиции чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

//Надо не забыть сделать
// void Print(int[,] arr)
// {
//     int row_size = arr.GetLength(0);
//     int column_size = arr.GetLength(1);

//     for (int i = 0; i < row_size; i++)
//     {
//         for (int j = 0; j < column_size; j++)
//         {
//             Console.Write($" {arr[i, j]} ");
//         } 
//         Console.WriteLine();       
//     }
//     Console.WriteLine();
// }

// int[,] MassNums(int row, int column, int from, int to)
// {
//     int[,] arr = new int[row, column];

//     for (int i = 0; i < row; i++)
//     {   
//         for (int j = 0; j < column; j++)
//         {
//             arr[i, j] = new Random().Next(from, to);
//         }        
//     }
//     return arr;
// }



// Console.WriteLine("Enter the number of rows: ");
// int row = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter the number of columns: ");
// int column = int.Parse(Console.ReadLine());

// int[,] arr_1 = MassNums(row, column, 1, 101);
// Print(arr_1);

int[,] CreateEmpty2DArray(int rowsNumber, int columnsNumber){
    return new int[rowsNumber,columnsNumber];
}

void Fill2DArray(int[,] array2D, int minBorderForRandom, int maxBorderForRandom){
    int rowsNumber = array2D.GetLength(0);
    int columnsNumber = array2D.GetLength(1);
    for (int row_index = 0; row_index < rowsNumber; row_index++){
        for (int column_index = 0; column_index < columnsNumber; column_index++){
            array2D[row_index, column_index] = new Random().Next(minBorderForRandom, maxBorderForRandom);
        }
    }
}
void Print2DArray(int[,] array2D){
    int rowsNumber = array2D.GetLength(0);
    int columnsNumber = array2D.GetLength(1);
    for (int row_index = 0; row_index < rowsNumber; row_index++){
        for (int column_index = 0; column_index < columnsNumber; column_index++){
            Console.Write($"{array2D[row_index, column_index],4:D} ");
        }
    Console.WriteLine();
    }
}

void Modify2DArray(int[,] array2D){
    int rowsNumber = array2D.GetLength(0);
    int columnsNumber = array2D.GetLength(1);
    for (int row_index = 0; row_index < rowsNumber; row_index++){
        for (int column_index = 0; column_index < columnsNumber; column_index++){
            if((row_index + 1) % 2 == 0 && (column_index + 1) % 2 == 0){
                array2D[row_index, column_index] *= array2D[row_index, column_index];
            }
        }
    }
}

int[,] array2D = CreateEmpty2DArray(3, 3);
Fill2DArray(array2D, 1, 10);
Print2DArray(array2D);
Modify2DArray(array2D);
Console.WriteLine();
Print2DArray(array2D); 