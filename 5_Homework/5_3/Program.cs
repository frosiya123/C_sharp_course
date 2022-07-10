//Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
void Print(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size)
{
    double[] arr = new double[size];
    Random n_new = new Random();
    for (int i = 0; i < size; i++)
    {
       // arr[i] = new Random().Next(-10, 10);
       arr[i] = Math.Round(n_new.NextDouble() * (10 + 12) - 10, 2); 
       //для вещественных числе добавляется запись на стр.16 и запись на 
       //строке 20
    }
    return arr;
}
double spliceMinMax(double[] array){
    double min = array[0];
    double max = array[0];

    for( int i =0; i< array.Length;i++){
        if( array[i] < min ){
            min = array[i];
        }
        if( array[i] > max ){
            max = array[i];
        }
    }
    return max - min;
}

double[] arr_1 = MassNums(10);
Print(arr_1);
Console.WriteLine(spliceMinMax(arr_1));
