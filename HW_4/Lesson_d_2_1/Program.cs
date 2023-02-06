// 1 способ
// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное
// и влево, если отрицательное.
Console.Clear();
Console.Write("Введите количество элементов массива A[1..N]: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите элементы массива A[1..N]:");
int[] A = new int[N];
int[] B = new int[N];
for (int i = 0; i < N; i++)
    {
    Console.Write($"A[{i}]: ");
    A[i] = Convert.ToInt32(Console.ReadLine());    
    }

Console.Write($"Введите число {0} < K < {N}: ");
int K  = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < A.Length - K; i++)
    B[i + K] = A[i];
for (int i = A.Length - K; i < A.Length; i++)
    B[i + K - A.Length] = A[i];

Console.WriteLine("Результат:");

for (int i = 0; i < N; i++)
    {
    Console.Write($"{B[i]}, ");
    }



