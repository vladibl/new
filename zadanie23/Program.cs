int a;
Console.WriteLine("введите число: ");
a = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= a; i++)
{
    Console.Write(Math.Pow(i , 3) + " , ");
}