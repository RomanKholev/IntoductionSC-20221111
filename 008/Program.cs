// Вывести на экран числа от -N до N
int N=Convert.ToInt32(Console.ReadLine());
int i=N*-1;
while(i<=N)
{
    System.Console.Write($"{i} ");
    i=i+1;
}

