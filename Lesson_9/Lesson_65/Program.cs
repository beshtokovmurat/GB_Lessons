//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Clear();
string rec(int n, int m)
{
    if (m == n)
        return $"{n}, ";
    return rec(n, m - 1)+ $"{m}, ";
}



Console.Clear();
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(N, M));