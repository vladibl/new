

    Console.Write("Введите количество элементов массива: ");
    int elementCount = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[elementCount];

    for (int i = 0; i < array.Length; i++)                    //ввод массива
    {
        Console.Write($"Введите элемент массива {i} ");
        array[i] = Convert.ToInt32(Console.ReadLine());

    }




void BubbleSort(int[] array)
{

for (int i = 0; i < array.Length; i++)
    for (int j = 0; j < array.Length - 1; j++)
    {
        if (array[j] < array[j + 1])           //Сортировка массива 

        {
            int k = array[j];
            array[j] = array[j + 1];
            array[j + 1] = k;

        }
    }

}

BubbleSort(array);

Console.WriteLine("вывод массива");
for (int i = 0; i < array.Length; i++)          //вывод массива
{
    Console.WriteLine(array[i]);
}








