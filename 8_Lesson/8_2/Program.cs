// Задайте двумерный массив. Напишите программу,
//которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

string ReplaceRow(int[,] array){
int row = array.GetLength(0);
int column = array.GetLength(1);
if (row != column) return "Не получается преобразовать. Введите квадратную матрицу";
for (int i = 0; i < row; i++){
        for (int j = 0; j < i; j++){
            (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
        }
    }
    return "yes";
}

Console.WriteLine("Введите число строк: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число столбцов: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,]array_1 = MasNumbers(row, column, 1, 30);
Print(array_1);

Console.WriteLine(ReplaceRow(array_1));
Print(array_1);

