// Дана строка, состоящая из N попарно различных символов. Требуется вывести все перестановки символов данной строки.
Console.Clear();
Console.Write("Введите строку, состоящую из N попарно различных символов: ");

string S = new String(Console.ReadLine());
Console.Write("Символы: ");
Console.WriteLine(S);
char temp = S[0];
char[] tmp = S.ToCharArray();
int k = 0;

void Perestanovka(char[] tmp1, int i, int n)
{
    if (i == n - 1)
    {
        k++;
        Console.WriteLine(k + " --> " + String.Concat(tmp1));
    }
    for (int j = i; j < n; j++)
    {
        temp = tmp1[i];
        tmp1[i] = tmp1[j];
        tmp1[j] = temp;
        Perestanovka(tmp1, i + 1, n);
        temp = tmp1[i];
        tmp1[i] = tmp1[j];
        tmp1[j] = temp;
    }
}

Perestanovka(tmp, 0, tmp.Length);
