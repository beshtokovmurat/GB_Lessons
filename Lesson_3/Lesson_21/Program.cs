Console.Clear();
Console.WriteLine("Введите координату X1 точки А");
int X1  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y1 точки А");
int Y1  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X2 точки B");
int X2  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y2 точки B");
int Y2  = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2));

Console.WriteLine("Результат");
Console.WriteLine("Расстояние " + Math.Round(d,2));


