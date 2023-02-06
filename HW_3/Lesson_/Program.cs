Console.Clear();
Console.WriteLine("Введите количество кустов N > 2: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество ягод a на кусте под номером i");
int[] a = new int[N+1];
for (int i = 1; i <= N; i++)
    a[i] = Convert.ToInt32(Console.ReadLine());    

int max = a[1] + a[2] + a[3];
int p = 1;
for (int i = 1; i <= N-2; i++)
    {
    if (a[i] + a[i+1] + a[i+2] > max)
        {
        max = a[i] + a[i+1] + a[i+2];
        p = i;
        }        
    }
Console.WriteLine("Максимальное количество ягод " +  max + " на кусте под номерами " + p + ", " + $"{p +1}" + ", " + $"{p +2}");
