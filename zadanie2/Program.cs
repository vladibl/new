int a,b,c;
int max;
Console.WriteLine("введите числа: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
max=a;
if (b>max)max=b;
if (c>max)max=c;

Console.WriteLine("{0} наибольшее число",max);