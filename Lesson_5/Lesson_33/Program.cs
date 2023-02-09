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

Console.WriteLine("Результат:");
Console.Write("Введите любое числ K: ");
int K = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Начальный массив:[{string.Join(", ", A)}]");

int i1 = 0;
int p = 0;

Boolean flag = true;

while (i1 < N && flag)
    {
    if (A[i1] == K)  
        {
        Console.WriteLine("Да");
        flag = false;
        }
    i1 = i1 + 1;
    }
if (flag)  Console.WriteLine("Нет");




