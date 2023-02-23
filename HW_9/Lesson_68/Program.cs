// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
Console.Clear();
int rec(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return rec(m-1,1);
    return rec(m-1,rec(m,n-1));
}


Console.Clear();
Console.Write("Введите 1 число m>0: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 1 число n>0: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(rec(m,n));
