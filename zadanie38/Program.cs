
int findMin(int[] array)
{


    int min = int.MaxValue;
    foreach (var i in array)
    {
        if (i < min)
        {
            min = i;
        }
    }
    return min;
}

int findMax(int[] a)
{


    int max = int.MinValue;
    foreach (var i in a)
    {
        if (i > max)
        {
            max = i;
        }
    }
    return max;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}



int[] res = GetArray(5, -99 , -1);
Console.WriteLine(string.Join(" ", res));


Console.WriteLine(findMax(res) - findMin(res));









