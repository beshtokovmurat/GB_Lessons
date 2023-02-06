// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите любое целое число:");

int N = Convert.ToInt32(Console.ReadLine());

for (int i=-N; i <= N; i++)
    {
    Console.WriteLine(i + ", ");
    }


