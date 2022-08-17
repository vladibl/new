Console.WriteLine("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int DigitCount(int a)
{
    int result = 0;

    result = a % 10;
    a = a / 10;
    if (a > 0)
    {
        result = result + DigitCount(a);
    }
    return result;
}
Console.WriteLine(DigitCount(num));









