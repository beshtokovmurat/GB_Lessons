//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N
Console.Clear();
string rec(int n)
{
    if (n == 1)
        return "1";
    return $"{n}, " + rec(n - 1);
}


string rec1(int n)
{
    if (n == 1)
        return "1";
    return rec1(n - 1) + $", {n}";
}
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n));
Console.WriteLine(rec1(n));