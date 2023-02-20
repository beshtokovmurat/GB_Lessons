// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Console.Clear();
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //matrix[i, j] = new Random().Next(1, 21); // [1, 20]
            Console.Write($"matrix[{i}, {j}]= ");
            matrix[i, j] = Convert.ToInt32(Console.ReadLine()); // [1, 20]
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


void Reshenie(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(0); j++)
        {
            matrix3[i, j] = 0;
            int i1 = 0;
            int j1 = 0;
            while (i1 < matrix1.GetLength(1) && j1 < matrix2.GetLength(0))
            {
                Console.WriteLine($"matrix3[{i}, {j}] = matrix3[{i}, {j}] + matrix1[{i}, {j1}] * matrix2[{i1}, {j}]");
                Console.WriteLine($"{matrix3[i, j]} = {matrix3[i, j]} + {matrix1[i, j1]} * {matrix2[i1, j]}");
                matrix3[i, j] = matrix3[i, j] + matrix1[i, j1] * matrix2[i1, j];
                i1++;
                j1++;
            }
        }
    }
}


Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();  
int[,] matrix1 = new int[size[0], size[1]];
int[,] matrix2 = new int[size[1], size[0]];
int[,] matrix3 = new int[size[0], size[0]];
Console.WriteLine("Задайте прямоугольную матрицу A[N,M]");
InputMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine("Задайте прямоугольную матрицу A[M,N]");
InputMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine();
Reshenie(matrix1, matrix2, matrix3);
PrintMatrix(matrix3);
