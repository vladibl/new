/*int[] array = {5, 6, 7, 8, 9};
int summ = 0;
for (int i = 0; i < array.Length; i++)       //Среднее арифметическое
     summ += array[i];
int mid = summ/array.Length;
Console.WriteLine($"{mid} ");
*/
/*
int[] array = new int[] { 20, 33, 44, 55, 1, 12, 99, 11 };
for (int i = 0; i < array.Length; i++)

    for (int j = 0; j < array.Length - 1; j++)
    {
        if (array[j] > array[j + 1])           //Сортировка массива пузырьком

        {
            int k = array[j];
            array[j] = array[j + 1];
            array[j + 1] = k;

        }
    }

Console.WriteLine("вывод массива");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
*/

/*
int num;
Console.WriteLine("введите число: ");
num = Convert.ToInt32(Console.ReadLine());

int DigitCount(int num)

{

    int count = 0;                          //вывести количество цифр 
    while (num > 0)
    {

        count++;
        num /= 10;
        
        
    }
    
    return count;

}
Console.WriteLine(DigitCount(num));
*/
/*
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine($"квадрат числа {number} равен = {sqr}");
*/



/
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}



int[] array = GetArray(12, -9, 9);


int positiveSum = 0;
int negativeSum = 0;

foreach (int el in array)
{
    positiveSum += el > 0 ? el : 0;
    negativeSum += el < 0 ? el : 0;
}
Console.WriteLine(string.Join (" ", array));
Console.WriteLine($"PositiveSum = {positiveSum}, negativeSum = {negativeSum}");




/*

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int[] array = GetArray(5, -10, 11);

int[] rev(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] *= -1;
    }
    return mas;
}



Console.WriteLine(String.Join(" ", array));

Console.WriteLine(String.Join(" ", rev(array)));

*/


/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да

bool FindArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            return true;
        }
    }
    
    return false;
}

int[] GetArr(int num)
{
    int[] arr = new int[num];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("введите значение элемента маcсива =");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

Console.Write("размер маcсива =");
int num = int.Parse(Console.ReadLine());
int[] array = GetArr(num);//задаем массив

Console.Write("Число для поиска: ");
int number = int.Parse(Console.ReadLine());
if (FindArray(array, number))
{
    Console.WriteLine("Да");
}
else
Console.WriteLine("Нет");

*/





