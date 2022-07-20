//  Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных. Значения элементов массива 0..9
// 25 мин
// Набор данных Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

void Print(int[,] array){
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    for (int i = 0; i < row_size; i++){
        for (int j = 0; j < column_size; j++){
            Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] Massiv(int row, int column, int from, int to){
    int[,]array = new int[row, column];
    for (int i = 0; i < row; i++){
        for (int j = 0; j < column; j++){
            array[i, j] = new Random().Next(from, to);
        }

    }
    return array;
}

int[] Number(int[,] arr){
 int[] array = new int[10];
  foreach (int item in arr) array[item]++;
  return array;
}

void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++){
            Console.Write($"{i} - {array[i] } ");
            Console.WriteLine();
        }
        Console.WriteLine();
}

Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = Massiv(row, column, 1, 10);
Print(arr_1);
int[] array_1 = Number(arr_1);
PrintArray(array_1);
