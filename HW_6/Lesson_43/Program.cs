// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
Console.Write("Введите коэффициент k1 первого уравнения: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите свободный член b1 первого уравнения: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэффициент k2 второго уравнения: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите свободный член b2 второго уравнения: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write($"Точка пересечения двух прямых ({Math.Round((b2-b1)/(k1-k2),2)}, {Math.Round(k1*(b2-b1)/(k1-k2)+b1,2)})");
