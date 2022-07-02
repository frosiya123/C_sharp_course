// Третья задача, с более понятным решением. Но вводить данные надо сдесь же
void OneOfNum(int num_1, int num_2)
{
if (num_1 % num_2 == 0)
{
Console.WriteLine($"{num_1}, {num_2} -> кратные");
}
else
{
Console.WriteLine($"{num_1}, {num_2} -> не кратные, остаток от деления {num_1 % num_2}");
}
}

OneOfNum(16, 4);
OneOfNum(22, 4);