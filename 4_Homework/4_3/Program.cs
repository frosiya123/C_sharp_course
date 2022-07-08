//Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
//int[] numbers = { 1, 2, 3, 4, 5 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.Write($" {numbers[i]}");
//}
void FillArray(int[] number)
{
    int length = number.Length; 
    int index = 0;
    while (index < length)
    {
         number[index] = new Random().Next(1, 100);      
        index++;
    }

}
void PrintArray(int[] num)
{
    int count = num.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($" {num[position]}");
        position++;
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);
