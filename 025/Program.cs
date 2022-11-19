// Вывести на экран кубы чисел от 1 до N
System.Console.WriteLine("Введите N");
int n=Convert.ToInt32(Console.ReadLine());
double Square (int a)
{
  returna=a*a;
}
System.Console.WriteLine("Число|  Квадрат");
for(int i=1;i<=n;i++)
{
    System.Console.WriteLine($"{i,5}|{Square(i),8}");
    
}