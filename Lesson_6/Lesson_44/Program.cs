Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int a = 0;
int b = 1;
int x = 0;

for (int i = 0; i < n; i++)
    {
    Console.Write(a);
    x = a;
    a = b; 
    b = x + b;
    }
