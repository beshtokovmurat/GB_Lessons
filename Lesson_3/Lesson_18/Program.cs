Console.Clear();
Console.WriteLine("Введите номер координатной четверти от 1 до 4: ");
int N = Convert.ToInt16(Console.ReadLine());

if (N < 1 || N > 4)
    Console.WriteLine("Ошибка! Вводите номер координатной четверти от 1 до 4: ");
else if (N == 1)
    {
    Console.WriteLine("X > 0");
    Console.WriteLine("Y > 0");
    }
else if (N == 2)
    {
    Console.WriteLine("X < 0");
    Console.WriteLine("Y > 0");
    }
else if (N == 3)
    {
    Console.WriteLine("X < 0");
    Console.WriteLine("Y < 0");
    }
else if (N == 4)
    {
    Console.WriteLine("X < 0");
    Console.WriteLine("Y < 0");
    }


