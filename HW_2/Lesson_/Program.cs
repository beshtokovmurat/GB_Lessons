Console.Clear();
Console.WriteLine("Введите через Enter последовательность чисел и завершите цифрой 0");
int n = Convert.ToInt32(Console.ReadLine());
int max_1 = n;
int max_2 = -1;
int max_3 = n;
bool flag = true;

while ( n != 0)
{
n = Convert.ToInt32(Console.ReadLine());
if (flag == true) 
    {  
    max_3 = n;
    flag = false;
    }
if (max_1 < n)
    {
    max_2 = max_1; 
    max_1 = n;
    }
else if (max_1 > n && max_3 < n) 
    {
    max_3 = n;    
    }
}
if (max_2 == -1)
    {
    Console.WriteLine("Второй максимальный элемент = " + max_3);
    }
else if (max_2 != -1)
    {
    Console.WriteLine("Второй максимальный элемент = " + max_2);
    }

