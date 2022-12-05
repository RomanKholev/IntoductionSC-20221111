//71. Показать натуральные числа от N до 1, N задано
void Loop(int N,int i)
{
    if (i<=N)
    {
        System.Console.WriteLine(N);
        Loop(N-1,i);
    }    
}

System.Console.WriteLine("Введите N");
int n=Convert.ToInt32(System.Console.ReadLine());
Loop(n,1);