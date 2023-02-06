// 2 способ
// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное
// и влево, если отрицательное.
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

Console.Write($"Введите число {0} < K < {N}: ");
int K  = Convert.ToInt32(Console.ReadLine());
int temp = 0;
int p = 0;

if (K > 0)
    {
    while (p < K)
        {
        temp = A[A.Length-1];
        for (int j = A.Length-1; j > 0; j--)
            A[j] = A[j-1];
        A[0] = temp;
        p++;
        }
    }

if (K < 0)
    {
    while (p < Math.Abs(K))
        {
        temp = A[0];
        for (int j = 0; j < A.Length-1; j++)
            A[j] = A[j+1];
        A[A.Length-1] = temp;
        p++;
        }
    }


Console.WriteLine("Результат:");

for (int i = 0; i < N; i++)
    {
    Console.Write($"{A[i]}, ");
    }



