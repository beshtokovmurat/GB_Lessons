Console.Clear();
Random rnd = new Random();
int n  = Convert.ToInt32(rnd.Next(100,999));

int a = n / 100;
int b = (n / 10) % 10;
int c = n % 10;

Console.WriteLine("Результат");
Console.WriteLine("Рассматриваемое число: " + n);
Console.WriteLine("Вторая цифра = " + b);
