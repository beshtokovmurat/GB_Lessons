//Задайте прямоугольный двумерный массив размером m×n, напишите программу, которая будет находить строку двумерного массива с наименьшей суммой элементов
Console.Clear();
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 21); // [1, 20]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}
int k = 0;
void Reshenie(int[,] matrix)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[0, j];
        k = 0;
    }
    int min = sum;
    for (int i = 1; i < matrix.GetLength(0); i++) 
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) sum = sum + matrix[i, j];
        if (sum < min)
        {
            min = sum;
            k = i;
        }
    }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальная матрица: ");
PrintMatrix(matrix);
Reshenie(matrix);
Console.WriteLine($"Cтрока с наименьшей суммой элементов: {k + 1}");
                                                                         