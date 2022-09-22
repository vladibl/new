int a;
Console.WriteLine("введите трехзначное число: ");
a = Convert.ToInt32(Console.ReadLine());
 int result = 0;
if(a > 99)
{
  result = (a / 100) % 10;
Console.WriteLine(result );
}
else
{
    Console.WriteLine("третьего числа нет");

}







