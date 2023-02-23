// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии
Console.Clear();
int p = 1;
string rec(int n, int m)
{
    if (m == 0)
        return $"Произведение {p}";
    p = p*n;
    return rec(n,m-1);
}


Console.Clear();
Console.Write("Введите число, которое нужно возвести в степень N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(rec(N,M));
