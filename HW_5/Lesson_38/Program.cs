// Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

int i = 0;
for (i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10); 

Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int max = array[0];
int min = array[0];

for (i=1; i < array.Length; i++) 
    {
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
    }
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {max-min}");
