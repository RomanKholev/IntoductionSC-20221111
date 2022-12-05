// 72. Показать натуральные числа от M до N, N и M заданы

void LoopPositive(int N,int i)
{
    if (i<=N)
    {
        System.Console.WriteLine(i);
        LoopPositive(N,i+1);
    }    
}

void LoopNegative(int N,int i)
{
    if (i<=N)
    {
        System.Console.WriteLine(N);
        LoopNegative(N-1,i);
    }    
}



System.Console.WriteLine("Введите M");
int m=Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите N");
int n=Convert.ToInt32(System.Console.ReadLine());

if (m>n) LoopNegative(m,n);
else LoopPositive(n,m);



