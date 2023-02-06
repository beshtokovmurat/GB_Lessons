
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите любое число N: ");
int N  = Convert.ToInt32(Console.ReadLine());

int s = 0;
int n1 = N;

while (n1 > 0)
    {
    s = s + n1 % 10;     
    n1 = n1/10;
    }

Console.WriteLine("Результат");
Console.WriteLine($"Cумма цифр в числе:  {s}");
// Console.WriteLine("Cумма цифр в числе: " + s);
