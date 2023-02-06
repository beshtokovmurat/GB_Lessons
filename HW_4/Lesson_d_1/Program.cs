// Требуется вычислить, сколько раз встречается некоторое число X в массиве A[1..N].
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

Console.Write("Введите число Х: ");
int X  = Convert.ToInt32(Console.ReadLine());

int k = 0;

for (int i = 0; i < A.Length; i++)
    if (X == A[i]) k++;
Console.WriteLine("число X в массиве A[1..N] встречается " + k  + " раз (а)");
