// Вывести на экран таблицу квадратов чисел от 1 до N
System.Console.WriteLine("Введите N");
int n=Convert.ToInt32(Console.ReadLine());
double Square (int a)
{
  return a=a*a;
}

for(int i=1;i<n+1;i++)
{
    System.Console.WriteLine($"{i}^2={Square(i)}");
    
}