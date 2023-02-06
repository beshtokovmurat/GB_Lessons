Console.Clear();
Console.WriteLine("Введите любое число от 1 до 7:");

int n = Convert.ToInt32(Console.ReadLine());

if (n < 1 || n > 7) 
    {
    Console.WriteLine("Ошибка! Введите любое число от 1 до 7");
    }

Console.WriteLine("Результат");
if (n == 1 || n == 2 || n == 3 || n == 4 || n == 5)
    {
    Console.WriteLine("Нет");
    }
else if (n == 6 || n == 7)
    {
    Console.WriteLine("Да");
    }
