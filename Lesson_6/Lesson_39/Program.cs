Console.Clear();
Console.Write("Введите количество элементов массива A[1..N]: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите элементы массива A[1..N]:");
int[] A = new int[N];
int i = 0;
for (i = 0; i < N; i++)
    {
    Console.Write($"A[{i}]: ");
    A[i] = Convert.ToInt32(Console.ReadLine());    
    }

Console.WriteLine("Результат:");

Console.WriteLine($"Начальный массив:[{string.Join(", ", A)}]");

int temp = 0;

for (i = 0; i < N / 2; i++)
    {
    temp =  A[i];
    A[i] = A[N - i - 1];    
    A[N - i - 1] = temp;
    }
Console.WriteLine($"Конечный массив:[{string.Join(", ", A)}]");



