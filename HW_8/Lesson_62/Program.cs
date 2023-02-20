// Напишите программу, которая заполнит спирально массив 4 на 4
Console.Clear();
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 1); // [1, 20]
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
int Gorizontal(int[,] matrix, int i, int j1, int j2, int K) // запись по горизонтали
{
    if (j1 < j2)
    {
        for (int j = j1; j <= j2; j++)
        {
            matrix[i, j] = K;
            K++;
        }
    }
    if (j2 < j1)
    {                                                                      
        for (int j = j1; j >= j2; j--)
        {
            matrix[i, j] = K;
            K++;
        }
    }
    return K;
}

int Vertical(int[,] matrix, int j, int i1, int i2, int K)  // запись по вертикали
{
    if (i1 < i2)
    {
        for (int i = i1; i <= i2; i++)
        {
            matrix[i, j] = K;
            K++;
        }
    }
    if (i2 < i1)
    {
        for (int i = i1; i >= i2; i--)
        {
            matrix[i, j] = K;
            K++;
        }
    }
    return K;
}
int Obhod(int[,] matrix, int level, int start1, int start2, int k0_1, int k0_2, int k)
{
    k = Gorizontal(matrix, level, start1, k0_2, k); // запись по горизонтали
    k = Vertical(matrix, k0_1, start1, k0_2, k); // запись по вертикали
    k = Gorizontal(matrix, k0_1, k0_1, start2, k);
    k = Vertical(matrix, level, k0_1, start2, k);
    return k;
}
int N = 1;
void Reshenie(int[,] matrix)
{
//  Цикл для обхода по 4 сторонам матрицы
    for (int i = 0; i < matrix.GetLength(0) / 2; i++)
        N = Obhod(matrix, i, i, i+1, matrix.GetLength(0) - (i+1), matrix.GetLength(0) - (i+2), N); 

//  Запись центрального элемента
    if (matrix.GetLength(0) % 2 !=0) matrix[matrix.GetLength(0) / 2,matrix.GetLength(0) / 2] = N;

//  Обход центра с четной размерностью (4 центральных элемента)
    if (matrix.GetLength(0) % 2 ==0) matrix[matrix.GetLength(0) / 2-1,matrix.GetLength(0) / 2-1] = N;
    if (matrix.GetLength(0) % 2 ==0) matrix[matrix.GetLength(0) / 2-1,matrix.GetLength(0) / 2] = N+1;
    if (matrix.GetLength(0) % 2 ==0) matrix[matrix.GetLength(0) / 2,matrix.GetLength(0) / 2] = N+2;
    if (matrix.GetLength(0) % 2 ==0) matrix[matrix.GetLength(0) / 2,matrix.GetLength(0) / 2-1] = N+3;
}


Console.Clear();
Console.Write("Введите размер массива NxN: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальная матрица: ");
PrintMatrix(matrix);
Reshenie(matrix);
Console.WriteLine();
Console.WriteLine("Конечная матрица: ");
PrintMatrix(matrix);
