// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
void RandomIntArray(out int[] a, int size=10)
{
    a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(0,2);    
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}



int[] m;
RandomIntArray(out m,size:8);
Print(m);
