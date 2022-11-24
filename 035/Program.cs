// Написать программу замены элементов массива на противоположные

void RandomIntArray(out int[] a, int size=10,int min=0,int max=100)
{
    a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max);    
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}
void Replace(int[] a)
{
   for(int i=0;i<a.Length;i++)
        a[i]=a[i]*-1;
}
int[] m;
RandomIntArray(out m, min:-100,max:100,size:20);
Print(m);
System.Console.WriteLine();
Replace(m);
Print(m);