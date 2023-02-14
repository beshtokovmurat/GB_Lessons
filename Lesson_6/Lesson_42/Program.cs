Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

string S = String.Empty;

Console.WriteLine($"Результат:");

Console.WriteLine($"Число {n}");
while (n !=0) 
    {
    S = Convert.ToString(n%2) + S;
    n = n/2;
    }
Console.Write(S);
