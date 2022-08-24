Console.Write("Введите количество цифр : ");
int elementCount = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elementCount];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите число {i} ");
    array[i] = Convert.ToInt32(Console.ReadLine());

}

int Comparison(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}



Console.WriteLine($"Введено чисел больше 0: {Comparison(array)} ");
