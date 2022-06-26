int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

int max = x;

if(x > max) max = x;
if(y > max) max = y;

Console.Write("max = ");
Console.WriteLine(max);