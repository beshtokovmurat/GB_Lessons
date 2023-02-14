// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.Write("Введите количество элементов: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];

int i = 0;
for (i = 0; i < array.Length; i++)
    {
    Console.Write($"array[{i}] =");
    array[i] = Convert.ToInt32(Console.ReadLine()); 
    }

Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int k = 0;

for (i=0; i < array.Length; i++)
    {
    if (array[i] > 0) k ++;
    }
Console.WriteLine($"Количество чисел больших 0: {k}");
