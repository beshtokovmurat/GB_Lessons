//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
Console.Clear();
int rec(int m, int n)
{
    if (n == m)
        return m;
    return rec(m, n - 1)+ n;
}

Console.Clear();
Console.Write("Введите 1 натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 натуральное число N>M: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(M, N));