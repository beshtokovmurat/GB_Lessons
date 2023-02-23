//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Clear();
string rec(int n, int m)
{
    if (n == m)
        return $"{m}";
    return $"{n}, " + rec(n - 1, m);
}


string rec1(int n, int m)
{
    if (n == m)
        return $"{m}";
    return rec1(n - 1, m) + $", {n}";
}
Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n>m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec1(n, m));
Console.WriteLine(rec(n, m));
