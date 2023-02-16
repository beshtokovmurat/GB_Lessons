// Заданы две матрицы n на m, состоящие из символов «B» и «W». Нужно сравнить и выдать разницу.
Console.Clear();
void InputMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"matrix[{i}, {j}] = ");
            matrix[i, j] = Convert.ToChar(Console.ReadLine());
        }
        Console.WriteLine();
    }
}

void PrintMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void Reshenie(char[,] matrix1, char[,] matrix2)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (matrix1[i, j] != matrix2[i, j])
            {
                matrix1[i, j] = '0';
                matrix2[i, j] = '0';
            }
        }
        Console.WriteLine();
    }
}
int k = 0;

void Rezult(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (matrix[i, j] != '0')
            {
                Console.Write($"{matrix[i, j]} \t");
                k++;
            }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
char[,] matrix1 = new char[size[0], size[1]];
char[,] matrix2 = new char[size[0], size[1]];
Console.WriteLine("Введите данные исходного изображения: ");
InputMatrix(matrix1);
Console.WriteLine("Введите данные полученного Мишей изображения: ");
InputMatrix(matrix2);
Console.WriteLine("Исходное изображение: ");
PrintMatrix(matrix1);
Console.WriteLine("Полученное Мишей изображение: ");
PrintMatrix(matrix2);
Reshenie(matrix1, matrix2);
Console.WriteLine("Результат сравнения: ");
Console.WriteLine("Исходное изображение: ");
Rezult(matrix1);
k = 0;
Console.WriteLine("Полученные Мишей ошибки: ");
Rezult(matrix2);
Console.WriteLine($"Число пикселей негатива, которые неправильно сформированы Мишиной программой: {k} ");
