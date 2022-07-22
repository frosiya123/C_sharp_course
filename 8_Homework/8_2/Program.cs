// Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов

void Print(int[,] array){
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    for (int i = 0; i < row_size; i++){
        for (int j = 0; j < column_size; j++){
            Console.Write($"{array[i,j],3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MasNumbers(int row, int column, int from, int to){
    int[,]array = new int[row, column];
    for (int i = 0; i < row; i++){
        for (int j = 0; j < column; j++){
            array[i,j] = new Random().Next(from, to);
        }
    }
    return array;
}

void MinRow(int[,] array){
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    int minSum = 1000;
    int minRow = 0;
    for (int i = 0; i < row; i++){
        int newSum = 0;
        for (int j = 0; j <  column; j++) newSum = newSum + array[i, j];
            Console.WriteLine($"{i+1} -> {newSum}; ");
        if (newSum < minSum)
        {
            minSum = newSum;
            minRow = i+1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Наименьшая сумма элементов: {minSum} находится в строке {minRow}.");
}


Console.WriteLine("Введите число строк: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число столбцов: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,]array_1 = MasNumbers(row, column, 1, 30);
Print(array_1);

MinRow(array_1);
