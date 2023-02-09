// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

int i = 0;
for (i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10); 

Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int sum = 0;

for (i=1; i < array.Length; i = i+2) sum = sum + array[i];
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {sum}");
