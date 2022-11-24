// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] RandomIntArray(int size=10,int min=100,int max=999)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

int CounterOdd (int[] a)
{
    int s=0;
       foreach(int el in a)
if(el%2==1) s++;
    return s;
}
int CounterEven (int[] a)
{
    int s=0;
       foreach(int el in a)
if(el%2==0) s++;
    return s;
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] a=RandomIntArray(20,100,999);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Количество ченых чисел : {CounterEven(a)}");
System.Console.WriteLine($"Количество неченых чисел : {CounterOdd(a)}");