// Программа проверяет пятизначное число на палиндромом.
System.Console.WriteLine("Введите пятизначное число: ");
string n=(System.Console.ReadLine());
int s=Convert.ToInt32(n.Length); 
while (s != 5)
{
System.Console.Write("Введите пятизначное число: ");
n=(System.Console.ReadLine());
s=Convert.ToInt32(n.Length);
}
char[] numbers = n.ToCharArray();
if (numbers[0]==numbers[4] && numbers[1]==numbers[3]) 
{
    System.Console.WriteLine($"Число {n} явдяется палиндромом");
 }
 else 
 {
    System.Console.WriteLine($"Число {n} не явдяется палиндромом");
 }