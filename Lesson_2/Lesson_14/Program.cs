Console.Clear();
Console.WriteLine("Введите число a");
int a  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Результат");

if (a % 7 == 0 && a % 23 == 0) 
    {
    Console.WriteLine(a + " кратно " + 7 + ", " + a + " кратно " + 23);
    }
else 
    {
    Console.WriteLine(a + " не кратно 7 и 23 одновременно ");
    }


