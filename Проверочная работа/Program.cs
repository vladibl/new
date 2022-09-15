string[] array1 = new string[7] { "34", "1", "hello", "world", "result","war","no" };
string[] array2 = new string[array1.Length];
void Arraysec(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void Printarray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Arraysec(array1, array2);
Printarray(array2);