Console.Clear();
Console.WriteLine("Введите любое число N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вывод результатов:");
for (int i=1; i <= N; i++)
    {
    if (i % 2 == 0)  
    {
    Console.WriteLine(i);
    }
    }


