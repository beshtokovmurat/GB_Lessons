Console.Clear();
Console.Write("Введите количество элементов массива A[1..N]: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите элементы массива A[1..N]:");
int[] A = new int[N];
for (int i = 0; i < N; i++)
    {
    Console.Write($"A[{i}]: ");
    A[i] = Convert.ToInt32(Console.ReadLine());    
    }

for (int i = 0; i < N; i++)
    {
    if (A[i]> 0)  A[i] = (-1)*A[i];
    else if (A[i]< 0)  A[i] = (-1)*A[i];
    }

Console.WriteLine("Результат:");

for (int i = 0; i < N; i++)
    {
    Console.Write($"{A[i]}, ");
    }



