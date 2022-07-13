// Пользователь вводит с клавиатуры М чисел. Посчитайте сколько чисел 
//больше 0 ввел пользователь
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223 ->3
Console.Write("Введите числа(через пробел): ");
string[] arr = Console.ReadLine().Split();
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    int number;
    if( !int.TryParse(arr[i],out number) )
    {
        Console.WriteLine($"{i+1} Символ {arr[i]} не является целым числом");
        continue;
    }
    if (number > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Больше нуля: {count}");
