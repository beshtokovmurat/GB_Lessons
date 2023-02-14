Console.Clear();

Console.WriteLine("Введите 3 числа");
Console.Write("Введите 1 число: ");
int N1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число: ");
int N2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 3 число: ");
int N3 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Результат:");

if (N1 + N2 > N3  && N2 + N3 > N1 && N1 + N3 > N2) Console.Write($"Да");
else Console.Write($"Нет");


