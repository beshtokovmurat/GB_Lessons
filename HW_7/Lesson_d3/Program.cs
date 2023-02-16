// Заданы две матрицы n на m, состоящие из символов «B» и «W». Нужно сравнить и выдать разницу.
//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
Console.Clear();
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (i == 0 && j <= matrix.GetLength(0))
                matrix[i, j] = matrix[i, j - 1] + j;
            else if (i == 0 && j >= matrix.GetLength(0))
                matrix[i, j] = matrix[i, j - 1] + matrix.GetLength(0);
            else if (i != 0 && j < matrix.GetLength(1))
                matrix[i, j - 1] = matrix[i - 1, j] + 1;
            if (i != 0 && j == (matrix.GetLength(1) - 1) && matrix.GetLength(1) >= matrix.GetLength(0))
                matrix[i, matrix.GetLength(1) - 1] = matrix[i - 1, matrix.GetLength(1) - 1] + matrix.GetLength(0) - i + 1;

            if (i != 0 && j == (matrix.GetLength(1) - 1) && matrix.GetLength(1) < matrix.GetLength(0))
                matrix[i, matrix.GetLength(1) - 1] = matrix[i - 1, matrix.GetLength(1) - 1] + matrix.GetLength(1);

            if (i == (matrix.GetLength(0) - 2) && j == (matrix.GetLength(1) - 1) && matrix.GetLength(1) < matrix.GetLength(0))
                matrix[i, matrix.GetLength(1) - 1] = matrix[i - 1, matrix.GetLength(1) - 1] + matrix.GetLength(1) - j + 2;

            if (i == (matrix.GetLength(0) - 1) && j == (matrix.GetLength(1) - 1) && matrix.GetLength(1) < matrix.GetLength(0))
                matrix[i, matrix.GetLength(1) - 1] = matrix[i - 1, matrix.GetLength(1) - 1] + matrix.GetLength(1) - j + 1;
        }
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


Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
