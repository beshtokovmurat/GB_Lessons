// Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть, чтобы оставаться ударником. 
// В текущей четверти Вася заметил следующую закономерность: по нечетным дням месяца он получал тройки, 
// а по четным – четверки. Так же он помнит, в какие дни он получал эти оценки. 
// Поэтому он выписал на бумажке все эти дни для того, чтобы оценить, сколько у него троек и сколько четверок. 
// Помогите Васе это сделать, расположив четные и нечетные числа в разных строчках. Вася может рассчитывать на оценку 4, если четверок не меньше, чем троек.
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] array1 = new int[n];
int[] array2 = new int[n];
int k1 = 0;
int k2 = 0;

int i = 0;
Console.WriteLine("Введите элементы массива больше 1, меньше 31: ");
for (i = 0; i < array.Length; i++)
    {
    Console.Write($"A[{i}]: ");
    array[i] = Convert.ToInt32(Console.ReadLine());    
    }


Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

for (i = 0; i < array.Length; i++) 
    {
    if (array[i] % 2 != 0) 
        {
        array1[k1] = array[i];
        k1++;
        }
    if (array[i] % 2 == 0) 
        {
        array2[k2] = array[i];
        k2++;
        }
    }

for (i = 0; i < k1; i++) 
    {
    if (array1[i] != 0) Console.Write($"{array1[i]}, ");
    }
Console.WriteLine();
for (i = 0; i < k2; i++) 
    {
    if (array2[i] != 0) Console.Write($"{array2[i]}, ");
    }
Console.WriteLine();
if (k1 > k2) 
    Console.WriteLine($"Нет");
else 
    Console.WriteLine($"Да");

