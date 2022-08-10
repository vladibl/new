int a,b;
Console.WriteLine("введите числа: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if(a % b == 0){
    Console.WriteLine(" ЧИСЛО 2 КРАТНО 1");
}
else{
    Console.WriteLine($"число не кртно 1,остаток от деления {0} ");   
} 