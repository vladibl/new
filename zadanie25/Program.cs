Console.WriteLine("введите два числа: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

int DigitCount(int num, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num;
    

    }
    return result;
}
DigitCount (num,num2);

Console.WriteLine(DigitCount(num,num2));