// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.
Console.Clear();
Console.WriteLine("Введите координату первой точки:");
Console.Write("X1: ");
double X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
double Y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату второй точки:");
Console.Write("X2: ");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
double Y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату третеьй точки:");
Console.Write("X3: ");
double X3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y3: ");
double Y3 = Convert.ToInt32(Console.ReadLine());

double p, a, b, c, S;

Console.WriteLine("Результаты");

a = Math.Sqrt(Math.Pow(X1-X2,2)+Math.Pow(Y1-Y2,2));
b = Math.Sqrt(Math.Pow(X1-X3,2)+Math.Pow(Y1-Y3,2));
c = Math.Sqrt(Math.Pow(X2-X3,2)+Math.Pow(Y2-Y3,2));

p = (a + b +c)/2;
S = Math.Sqrt(p*(p-a)*(p-b)*(p-c));

Console.WriteLine($"Площадь треугольника: {S}");