Console.Clear();
Console.WriteLine("Введите количество кустов N > 2: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество ягод a на кусте под номером i");
int[] a = new int[N];
for (int i = 0; i < a.Length; i++)
    a[i] = Convert.ToInt32(Console.ReadLine());    
int p = 0, p1 = 0, p2 = 0;
int max = a[a.Length-1] + a[0] + a[1];
p = a.Length-1; p1 = 0; p2 = 1;
for (int i = 0; i <= a.Length-3; i++)
    {
    if (a[i] + a[i+1] + a[i+2] > max)
        {
        max = a[i] + a[i+1] + a[i+2];
        p = i; p1 = i+1; p2 = i+2;
        }        
    }
if (a[a.Length-2] + a[a.Length-1] + a[0]>max) 
    {
    max = a[a.Length-2] + a[a.Length-1] + a[0];
    p = a.Length-2; p1 = a.Length-1; p2 = 0;
    }

Console.WriteLine($"Максимальное количество ягод {max} на кусте под номерами {p+1}, {p1+1}, {p2+1}");
