int a;
int t;
int n;
a=1;
t=6;
n=7;
Console.WriteLine("введите  число 1-7: ");
a = Convert.ToInt32(Console.ReadLine());
if (a < 6)
{
Console.WriteLine($"число {a} будний день");
}
else if (a == 6)
{
    Console.WriteLine($"число {t} выходной день");
}
else if (a == 7)
{
    Console.WriteLine($"число {n} выходной день");
}






