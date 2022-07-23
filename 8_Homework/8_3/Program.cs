// Задайте две матрицы. Напишите программу, которая будет
//находить произведение этих матриц
Console.WriteLine("Введите число строк: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число столбцов: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,]array_1 = MasNumbers(row, column, 1, 5);
Print(array_1);
//Console.WriteLine();
char X = 'X';
Console.WriteLine($"{X,7}");
Console.WriteLine();
int[,]array_2 = MasNumbers(row, column, 1, 5);
Print(array_2);
MultiplicationMatrix(array_1,array_2);

void MultiplicationMatrix(int[,] a, int[,] b){
    int[,] multMatr = new int[a.GetLength(0), a.GetLength(1)];

    for (int i = 0; i < a.GetLength(0); i++){
        for( int p = 0; p < a.GetLength(0); p++){
            for (int j = 0; j < a.GetLength(1); j++){
                multMatr[i,j] += a[i,p] * b[p,j]; 
            }
        }
    }
    Console.WriteLine("    =");
    Console.WriteLine();
    Print(multMatr);
}

void Print(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        Console.Write('|');
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j],3} ");
        }
        Console.WriteLine('|');
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

