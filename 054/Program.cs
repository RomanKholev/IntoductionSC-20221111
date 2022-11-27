// С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
int [] Fibonachi(int N)
{
if(N<2) N=2;     
int[] a=new int[N];
a[0] =0;
a[1] =1;
    for(int i=2;i<N;i++)
        a[i]=a[i-1]+a[i-2];
 
return a;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

System.Console.WriteLine("Введите число N: ");
int N=Convert.ToInt32(Console.ReadLine());
Print (Fibonachi(N));