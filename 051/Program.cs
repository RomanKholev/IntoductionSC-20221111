// С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

int[] IntArray(int N=10)
{
    System.Console.WriteLine($"Введите {N} чисел");
    int[] a=new int[N];
        for(int i=0;i<N;i++)
        a[i]=Convert.ToInt32(Console.ReadLine());
        return a;
   }

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int Count(int [] a)
{
    int count=0;
    for(int i=0;i<a.Length;i++)
        if(a[i]>0) count++;
    return count;
}

int N;
System.Console.WriteLine("Введите число N");
N=System.Convert.ToInt32(System.Console.ReadLine());
int[] a=IntArray(N);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Чисел больше 0 с клавиатуры введено: {Count(a)}");
