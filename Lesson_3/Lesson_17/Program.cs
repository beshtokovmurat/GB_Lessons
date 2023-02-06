Console.Clear();
Console.WriteLine("Введите координату X <> 0: ");
int X = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите координату Y <> 0: ");
int Y = Convert.ToInt16(Console.ReadLine());

if (X > 0 && Y > 0)
    {
    Console.WriteLine("Первая четверть");        
    }
else if (X < 0 && Y > 0)
    {
    Console.WriteLine("Вторая четверть");        
    }
else if (X < 0 && Y < 0)
    {
    Console.WriteLine("Третья четверть");        
    }
else if (X > 0 && Y < 0)
    {
    Console.WriteLine("Четвертая четверть");        
    }


