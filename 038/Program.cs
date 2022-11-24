// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] RandomIntArray(int size=10,int min=100,int max=999)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

int Counter (int[] a)
{
    int s=0;
       foreach(int el in a)
if (el>=10 && el<=99) s++;
    return s;
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] a=RandomIntArray(123,0,999);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Количество количество элементов из отрезка [10,99]: {Counter(a)}");
