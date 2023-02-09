// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

int i = 0;
for (i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 999); 

Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int k = 0;

for (i=0; i < array.Length; i++)
    {
    if (array[i] % 2 ==0) k ++;
    }
Console.WriteLine($"Количество четных чисел: {k}");
