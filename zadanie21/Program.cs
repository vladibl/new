Console.WriteLine("введите координаты x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты х3: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты z1: ");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты z2: ");

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance:f3}");