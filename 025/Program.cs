// Вывести на экран кубы чисел от 1 до N
System.Console.WriteLine("Введите N");
int n=Convert.ToInt32(Console.ReadLine());
double Сube(int a)
{
  return Math.Pow(a,3);
}

for(int i=1;i<n+1;i++)
{
    System.Console.WriteLine(Сube(i));
    
}