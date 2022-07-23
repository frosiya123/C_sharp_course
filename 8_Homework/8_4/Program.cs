// Задайте двумерный массив из целых чисел. Напишите программу,
//которая удалит строку и столбец, на пересечении которых
//расположен наименьший элемент массива

Console.WriteLine("Введите число строк: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число столбцов: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,]array_1 = MasNumbers(row, column, 1, 10);

int min = array_1[0,0];
Print(array_1);


int[] minStrCol = getMinStrCol(array_1);
int[,] getArray = delMinStrCol(array_1, minStrCol);

// Повторить столько раз сколько строк с минимальным значением будет найдено
while (true)
{
    minStrCol = getTwiceStrCol(getArray);
    if( minStrCol[0] == -1 ){
        break;
    }
    getArray = delMinStrCol(getArray, minStrCol);
}
Print(getArray);

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

int [] getMinStrCol(int[,] a){
    int[] ret = new int[2];
    int iS = 0;
    int iC = 0;
    for( int i = 0;i < a.GetLength(0);i++){
        for( int j = 0;j < a.GetLength(1);j++){
            if( min > a[i,j]){
                min = a[i,j];
                iS = i;
                iC = j;
            }
        }
    }
    ret[0] = iS;
    ret[1] = iC;
    return ret;
}

int [,] delMinStrCol(int[,] a, int[] delStr){
    int lSN = delStr[0];
    int lCN = delStr[1];

    int[,] dstArray = new int[a.GetLength(0) -1, a.GetLength(1) -1];

    int iS = 0;
    
    for( int i = 0;i < a.GetLength(0);i++){
        if( lSN == i ){
            continue;
        }
        int iC = 0;

        for( int j = 0;j < a.GetLength(1);j++){
            if( lCN == j ){
                continue;
            }
            dstArray[iS,iC] = a[i,j];
            iC++;
        }
        iS++;
    }
    return dstArray;
}

int[] getTwiceStrCol(int[,] a){
    int[] ret = new int[2];
    for( int i = 0;i < a.GetLength(0);i++){
        for( int j = 0;j < a.GetLength(1);j++){
            if( min == a[i,j]){
                ret[0] = i;
                ret[1] = j;
                return ret;
            }
        }
    }
    ret[0] = -1;
    ret[1] = -1;
    return ret;   
}