Console.WriteLine("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int DigitCount(int num)
{
    int result = 0;

    result = num % 10;
    num = num / 10;
    if (num > 0)
    {
        result = result + DigitCount(num);
    }
    return result;
}
Console.WriteLine(DigitCount(num));









