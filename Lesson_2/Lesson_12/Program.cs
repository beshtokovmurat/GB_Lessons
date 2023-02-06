Console.Clear();
Console.WriteLine("Введите число a");
int a  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b");
int b  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Результат");
if (a % b == 0) 
    {
    Console.WriteLine(a + " кратно " + b);
    }
else if (a % b != 0) 
    {
    Console.WriteLine(a + " не кратно " + b + ", остаток " + a % b);
    }


