Console.Clear();
//Console.Write("Введите число: ");
//int n = Convert.ToInt32(Console.ReadLine());
int n = 123;
int[] array = new int[n];
int i = 0;
for (i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 101); 

Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

int k = 0;
for (i=0; i < n; i++)
    {
    if (array[i] >= 10 && array[i] <= 99) k = k +1;
    }
Console.WriteLine($"Результат: {k}");
