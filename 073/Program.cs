// 73. Найти сумму элементов от M до N, N и M заданы

int SumNumbers(int M, int N)
{
    if (M<N) return SumNumbers(M, N-1)+N;
     else return M;
}

System.Console.WriteLine("Введите M");
int m=Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите N");
int n=Convert.ToInt32(System.Console.ReadLine());
if (n<m) System.Console.WriteLine("M олжно быть больше чем N");
else System.Console.WriteLine(SumNumbers(m,n));


