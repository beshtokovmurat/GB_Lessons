//Задайте двумерный массив размером m×n, напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
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
int temp = 0;
void Reshenie(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int max = matrix[i, j], temp = 0; k = j;
            for (int p = j + 1; p < matrix.GetLength(1); p++)
            {
                if (matrix[i, p] > max)
                {
                    max = matrix[i, p];
                    k = p;
                }
            }
            temp = matrix[i, j];
            matrix[i, j] = matrix[i, k];
            matrix[i, k] = temp;
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
Console.WriteLine();
Console.WriteLine("Конечная матрица: ");
PrintMatrix(matrix);
                                     