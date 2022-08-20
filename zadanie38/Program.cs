
int findMin(int[] arr)
{


    int min = int.MaxValue;
    foreach (var i in arr)
    {
        if (i < min)
        {
            min = i;
        }
    }
    return min;
}

int findMax(int[] arr)
{


    int max = int.MinValue;
    foreach (var i in arr)
    {
        if (i > max)
        {
            max = i;
        }
    }
    return max;
}



int[] arr = { 8, 3, 5, 1, 2 };



Console.WriteLine(findMax(arr) - findMin(arr));



