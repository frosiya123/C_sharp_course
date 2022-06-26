int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());

int max = x;

if(x > max) max = x;
if(y > max) max = y;
if(z > max) max = z;

Console.Write("max = ");
Console.WriteLine(max);