// 84 Определить являются ли введенные с клавиатуры символы правильно записью целого числа. Вычислить сумму цифр введенного числа

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
if (k<s.Length) sum=-1;
return sum;
}
 System.Console.WriteLine("Введите строку"); 
  string s=Console.ReadLine();
if (NumbersSum(s)<0) System.Console.WriteLine("Введенные символы не являются записью целого числа");
else System.Console.WriteLine($"Cумма цифр введенного числа = {NumbersSum(s)}");  