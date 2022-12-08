// Подсчитать сумму цифр, встречающихся в строке
int NumbersSum(string s)
{
int sum=0;
int k=0;
for(int i=0;i<s.Length;i++)

if (char.IsDigit(s[i]))
{
 
 sum=sum+s[i]-'0';
 k++;
 
}
if (k==0) sum=-1;
return sum;
}
 System.Console.WriteLine("Введите строку"); 
  string s=Console.ReadLine();
if (NumbersSum(s)<0) System.Console.WriteLine("В веденной строке нет цифр");
else System.Console.WriteLine($"Cумма встречающихся цифр = {NumbersSum(s)}");  