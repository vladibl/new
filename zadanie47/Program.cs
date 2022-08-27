Console.Write("Введите количество столбцов:  ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк:  ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            result[i, j] = new Random().NextDouble() * 20 - 10;



    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double alignNumber = Math.Round(array[i, j], 1);
            Console.Write(alignNumber);
        }
        Console.WriteLine();
    }
}


double[,] myArray = GetArray(m, n);
PrintArray(myArray);


