Console.Clear();
Console.WriteLine("Введите любое число a:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите любое число b:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите любое число c:");
int c = Convert.ToInt32(Console.ReadLine());

if (a >= b && a >= c)  
    {
    Console.WriteLine("max = " + a);
    }
else if (b >= a && b >= c)  
    {
    Console.WriteLine("max = " + b);
    }
else 
    {
    Console.WriteLine("max = " + c);
    }
