int a;
Console.WriteLine("введите трехзначное число: ");
a = Convert.ToInt32(Console.ReadLine());
int num1 = a / 10;
int num2 = num1 % 10;

int result = num2;
Console.WriteLine($"число такое {result} из {a}");