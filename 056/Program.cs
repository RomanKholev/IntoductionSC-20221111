// 56 Написать программу копирования массива

int[] RandomIntArray(int N,int min,int max)
{
    int[] a=new int[N];
    Random random=new Random();
    for(int i=0;i<a.Length;i++)
        a[i]=random.Next(min,max);
    return a;
}

void PrintArray(int[] a,int tab=5)
{
    string formatString="{0,"+tab+"}";
    for(int i=0;i<a.Length;i++)
        System.Console.Write(formatString,a[i]);
}

int[] Copy (int [] a)
{
    int []  copy = new int[a.Length];
    for(int i=0;i<a.Length;i++)
        copy[i]=a[i];
    return copy;
}

int [] a=RandomIntArray(10, 0, 100);
int [] b=Copy(a);
PrintArray(a);
System.Console.WriteLine();
PrintArray(b);