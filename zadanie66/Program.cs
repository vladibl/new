Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int s = 0;

int Addition(int m, int n)
{
    if (m > n)
    {
        for (int i = n; i <= m; i++)
        {
            s += i;
        }
    }
    if (m < n)
    {
        for (int i = m; i <= n; i++)
        {
            s += i;
        }
       
    }
    return(s);
}
Addition(m,n);
Console.WriteLine(s);

