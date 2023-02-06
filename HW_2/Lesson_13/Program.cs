Console.Clear();
Random rnd = new Random();
int n  = Convert.ToInt32(rnd.Next(10,999));

int a = n / 100;
int b = (n / 10) % 10;
int c = n % 10;

Console.WriteLine("Результат");

if (a != 0)
    {
    Console.WriteLine("Рассматриваемое число: " + n);
    Console.WriteLine("Третья цифра = " + c);
    }
else if (a == 0)
    { 
    Console.WriteLine(n + " - третьей цифры нет");
    }

