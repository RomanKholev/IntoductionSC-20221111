// 70. Показать натуральные числа от 1 до N, N задано

void Loop(int N,int i)
{
    if (i<=N)
    {
        System.Console.WriteLine(i);
        Loop(N,i+1);
    }    
}

System.Console.WriteLine("Введите N");
int n=Convert.ToInt32(System.Console.ReadLine());
Loop(n,1);