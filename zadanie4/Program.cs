
int number = new Random() .Next(100,1000);
int num1 = number % 10;
int num2 = number / 100;
int result = num2 * 10 + num1;
Console.WriteLine($"число такое {result} из {number}");



