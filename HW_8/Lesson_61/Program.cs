// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.
Console.Clear();
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = 0;
    }
}

void Reshenie(int[,] matrix)
{
    matrix[0, 0] = 1;
    matrix[1, 0] = 1;
    matrix[1, 1] = 2;
    matrix[1, 2] = 1;
    for (int i = 2; i < matrix.GetLength(0) - 1; i++)
    {
        matrix[i, 0] = 1;
        matrix[i, i + 1] = 1;
        for (int j = 1; j < i + 1; j++)
            matrix[i, j] = matrix[i - 1, j-1] + matrix[i - 1, j];
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (matrix[i, j] !=0)  Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите N>0: ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[N + 1, N + 1];
InputMatrix(matrix);
Reshenie(matrix);
Console.WriteLine();
Console.WriteLine("Треугольник  Паскаля: ");
PrintMatrix(matrix);
