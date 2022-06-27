int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

int max = x;
int min = y;

if(x > max) max = x;
if(x < min) min = x;
if(y > max) max = y;
if(y < min) min = y;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);