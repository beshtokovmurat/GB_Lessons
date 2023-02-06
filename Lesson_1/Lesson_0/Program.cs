// See https://aka.ms/new-console-template for more information
Console.Clear();

Console.WriteLine("Введите число N:");
int N = Convert.ToInt16(Console.ReadLine()); 
int i;
i = 1;
while(i < N + 1)
    {
    Console.WriteLine(Math.Pow(i,2));
    i++;
    }
