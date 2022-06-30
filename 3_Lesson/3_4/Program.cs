// 3. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N. 

void Pows(int num)
 {
     int count = 1; 
     while (count <= num) 
     { 
        Console.Write($"{Math.Pow(count, 2)} "); count++; 
        } 
} 
Pows(4); 