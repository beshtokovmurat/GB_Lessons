// Напишите программу, которая заполнит спирально массив 4 на 4
Console.Clear();
Console.WriteLine($"Задача 62: Заполните спирально массив N на N.");


Console.Write($"Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  Console.WriteLine($"Bход: i={i}, j={j}");
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    {
    Console.WriteLine($"1--> i={i}, j={j}");
    j++;
    Console.WriteLine($"1--> i={i}, j={j}");
    }
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    {
    Console.WriteLine($"2--> i={i}, j={j}");
    i++;
    Console.WriteLine($"2--> i={i}, j={j}");
    }
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    {
    Console.WriteLine($"3--> i={i}, j={j}");
    j--;
    Console.WriteLine($"3--> i={i}, j={j}");
    }
  else
    {
    Console.WriteLine($"4--> i={i}, j={j}");
    i--;
    Console.WriteLine($"4--> i={i}, j={j}");
    }
  Console.WriteLine($"Bыход: i={i}, j={j}");
  Console.WriteLine();
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
        Console.Write($" {array[i,j]} ");
      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

