// Задать массив из 8 целых элементов и вывести их на экран

void IntArray(out int[] a, int size=8)
{
    a=new int[size];
    
    for(int i=0;i<size;i++)
        a[i]=Convert.ToInt32(System.Console.ReadLine());    
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}


System.Console.Write("Введите 8 чисел: ");
int[] m;
IntArray(out m);
Print(m);
