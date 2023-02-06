// Известно, что любое чётное число, большее 2, представимо в виде суммы 2 простых чисел, 
// причём таких разложений может быть несколько. Впервые гипотезу о существовании данного разложения сформулировал математик Х. Гольдбах.
Console.Clear();
Console.Write($"Введите четное число N > 2: ");
int N  = Convert.ToInt32(Console.ReadLine());

while (N%2 != 0)
    {
    Console.Write($"Введите четное число N > 2: ");
    N  = Convert.ToInt32(Console.ReadLine());
    }
int a = 0;
int b = 0;
int Sa = 0;
int Sb = 0;
Boolean flag = true;
int i = 1;

Console.WriteLine("Результат:");
flag = true;
while (flag && i<=N)
    {
    a = i;
    b = N - a;
    Sa = 0;
    Sb = 0;
    for (int j = 1; j <= a; j++)
        {
        if (a % j == 0) 
            Sa++;   
        }
    for (int j = 1; j <= b; j++)
        {
        if (b % j == 0) 
            Sb++;   
        }
    if (a != 1 && Sa == 2 && b != 1 && Sb == 2)
        { 
        Console.WriteLine($"Четное число {N} представимо в виде суммы простых чисел: {a}, {b}");
        flag = false;
        }
    else i++;
    }




