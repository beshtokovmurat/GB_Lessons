// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
Console.Clear();
int sum = 0;
string rec(int n)
{
    if (n == 0)
        return $"Сумма {sum}";
    sum = sum + n%10;
    return rec(n/10);
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n));
