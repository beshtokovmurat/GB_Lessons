// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии
Console.Clear();
int rec(int n, int m)
{
    if (m == 0)
        return 1;
    return rec(n,m-1)*n;
}


Console.Clear();
Console.Write("Введите число, которое нужно возвести в степень N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(rec(N,M));
