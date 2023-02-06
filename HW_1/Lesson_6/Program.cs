Console.Clear();
Console.WriteLine("Введите любое число a:");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)  
    {
    Console.WriteLine("a = четное");
    }
else
    {
    Console.WriteLine("a = нечетное");
    }
