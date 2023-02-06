Console.Clear();
Random rnd = new Random();
int n  = Convert.ToInt32(rnd.Next(10,99));

int a = n / 10;
int b = n % 10;

Console.WriteLine("Рассматриваемое число: " + n);

if (a > b)
    {
    Console.WriteLine(a);        
    }
else if (a < b)
    {
    Console.WriteLine(b);        
    }

