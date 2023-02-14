Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[n];
int k = n/2 + n % 2;
int[] array2 = new int[k];
int i = 0;
for (i = 0; i < array1.Length; i++)
    array1[i] = new Random().Next(1, 10); 

Console.WriteLine($"Начальный массив: [{string.Join(", ", array1)}]");

for (i=0; i < k; i++)
    {
    array2[i] = array1[i]*array1[array1.Length-1-i];
    }
if (n % 2 == 1) array2[k-1] = array1[k-1];    
Console.WriteLine($"Конечный массив: [{string.Join(", ", array2)}]");
