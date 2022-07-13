// Напишите программу, которая будет создавать копию заданного
//двумерного массива с помощью поэлементного копирования.


void PrintArray(int[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            Console.Write($" {matrix[i,j]}");
        }
        Console.WriteLine();
    }
}

int[,] CopyArray(int[,] matrix) {
    int[,] arr = new int [matrix.GetLength(0),matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            arr[i,j] = matrix[i,j];
        }
    }
    return arr;
}

void FillArray(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for(int j = 0; j < matrix.GetLength(0); j++) {
            matrix[i,j] = new Random().Next(0, 4);
        }
    }
}
int[,] matrix = new int [3,4];
FillArray(matrix);
int[,] Arr = CopyArray(matrix);
PrintArray(matrix);
Console.WriteLine();
PrintArray(Arr);