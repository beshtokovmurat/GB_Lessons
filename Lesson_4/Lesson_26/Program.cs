Console.Clear();
Console.WriteLine("Введите любое число N: ");
int n  = Convert.ToInt32(Console.ReadLine());

int n1 = n; 
int k = 1;

while (n1/10 != 0)
    {
    k = k + 1;
    n1 = n1 / 10;
    }
Console.WriteLine("Рассматриваемое число: " + n);
Console.WriteLine("Количество: " + k);
// Console.WriteLine($"Результат: {count}");
