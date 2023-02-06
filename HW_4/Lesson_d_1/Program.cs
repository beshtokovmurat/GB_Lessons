Console.Clear();
Console.WriteLine("Введите пятизначное число:");
int n  = Convert.ToInt32(Console.ReadLine());

int a = 0, b = 0, c = 0, d = 0, e = 0;

Console.WriteLine("Результат");

if (n<10000 && n>99999)
    Console.WriteLine("Ошибка! Введите пятизначное число");
else if (n>10000 && n<99999)
    {
    a = n / 10000;
    b = (n / 1000) % 10;
    c = (n / 100) % 10;
    d = (n / 10) % 10;
    e = n % 10;
    }
Console.WriteLine(a + ", " + b + ", " + c + ", " + d + ", " + e);

if (a == e && b == d)
    Console.WriteLine("Да.  рассматриваемое число " + n  + " является полиндромом");
else   
    Console.WriteLine("Нет.  рассматриваемое число " + n  + " не является полиндромом");
