int a,b;
Console.WriteLine("введите числа: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    Console.WriteLine("{0} наибольшее число",a);
    Console.WriteLine("{0} наименьшее число",b);
}
else
{
        Console.WriteLine("{0} наибольшее число",b);
        Console.WriteLine("{0} наименьшее число",a);
}
Console.ReadLine();