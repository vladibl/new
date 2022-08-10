int a;
Console.WriteLine("введите трехзначное число: ");
a = Convert.ToInt32(Console.ReadLine());
if(a > 99)
{
    Console.WriteLine((a / 100) % 10 );
}
else
{
    Console.WriteLine("третьего числа нет");

}







