int a;
Console.WriteLine("введите пятизначное  число: ");
a = Convert.ToInt32(Console.ReadLine());
int bum = a;
int n2 = 0;
while ( a > 0 )
{
  n2 = ( n2 * 10 ) + ( a % 10);
a = ( a / 10 );
}

Console.WriteLine($"{n2}" );

if (bum == n2)
{
    Console.WriteLine("число палиндром");
}
else
{
    Console.WriteLine("число не палиндром");

}

