Console.Clear();
Console.WriteLine("Введите любое число N: ");
int n  = Convert.ToInt32(Console.ReadLine());
int p = 1;

for (int i = 1; i <= n; i++ )
    {
        p = p * i;
    }
Console.WriteLine("Рассматриваемое число: " + n);
Console.WriteLine("Результат: " + p);