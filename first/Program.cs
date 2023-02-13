int a = new Random().Next(1,11);
Console.WriteLine(a);
int b = new Random().Next(3,12);
Console.WriteLine(b);
int c = new Random().Next(13,16);
Console.WriteLine(c);
int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write(" max= ");
Console.WriteLine(max);