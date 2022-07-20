// Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку массива.

void Print(int[,]array){
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    for (int i = 0; i < row_size; i++){
        for (int j = 0; j < column_size; j++){
            Console.Write($"{array [i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MasNumbers(int row, int column, int from, int to){
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++){
        for (int j = 0; j < column; j++){
            array[i, j] = new Random().Next(from, to);
        }
    }
    return array;
}
void ReplaceRow(int[,] array){
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < row; i++){
        for (int j = 0; j < column; j++){
             (array[0, i], array[row - 1, i]) = (array[row - 1, i], array[0, i]);
        }
    }
}

Console.WriteLine("Введите число строк");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число столбцов");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MasNumbers(row, column, 1, 10);
Print(arr_1);

ReplaceRow(arr_1);
Print(arr_1);