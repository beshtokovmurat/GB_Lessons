Console.Clear();
Console.WriteLine("Введите число a");
int a  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b");
int b  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Результат");
if (a == Math.Pow(b,2) || b == Math.Pow(a,2)) 
    {
    Console.WriteLine(a + ", " + b + " да");
    }
else 
    {
    Console.WriteLine(a + ", " + b + " нет");
    }


