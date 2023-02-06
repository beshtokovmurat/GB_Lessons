// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.WriteLine("Введите два числа");
Console.Write("Введите первое число A: ");
int A  = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое число B: ");
int B  = Convert.ToInt32(Console.ReadLine());

int p = A;

for (int i = 1; i < B; i++)
    {  
    p = p * A;
    }

Console.WriteLine("Результат: ");
 Console.WriteLine($"Число A в натуральную степень B равно: {p}");
// Console.WriteLine("Число A в натуральную степень B равно: " + p);

