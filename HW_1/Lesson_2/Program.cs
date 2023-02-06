// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите любое число a:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите любое число b:");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) 
    {
    Console.WriteLine("max = " + a);
    Console.WriteLine("min = " + b);
    }
else if (a < b) 
    {
    Console.WriteLine("max = " + b);
    Console.WriteLine("min = " + a);
    }
