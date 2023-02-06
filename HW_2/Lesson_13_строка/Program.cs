Console.Clear();
int n = Math.Abs(Convert.ToInt32(Console.ReadLine())); 
string stroka = Convert.ToString(n); 
if (stroka.Length < 3)     
   Console.WriteLine("no"); 
else     
   Console.WriteLine(stroka[2]);