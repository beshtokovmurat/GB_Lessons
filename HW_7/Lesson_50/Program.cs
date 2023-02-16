// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
Console.Clear();
void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = Math.Round(new Random().NextDouble(), 2); // [1, 20]
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Write("Введите номер элемента строки i: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер элемента столбца j: ");
int M = Convert.ToInt32(Console.ReadLine());
Boolean flag = false;


void Reshenie(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (i == N && j == M) 
            {
            Console.Write($"Элемент массива с индесами {N}, {M} есть {matrix[i-1, j-1]}");
            flag = true;
            }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Reshenie(matrix);
if (flag == false) Console.Write($"Элемента массива с индесами {N}, {M} нет");

