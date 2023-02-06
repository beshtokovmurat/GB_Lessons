// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите два числа: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (x == Math.Pow(y,2) || y == Math.Pow(x,2))
    {
    Console.WriteLine("Да");
    }
else 
    {
    Console.WriteLine("Нет");
    }

