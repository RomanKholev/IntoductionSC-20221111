// Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. Создайте массив, который является произведением пар чисел в одномерном массиве a. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] RandomIntArray(int size=10,int min=1,int max=10)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int [] ProductArray(int[] a)
{
   int size = a.Length-1;
   int[] b=new int[size/2];  
for(int i=0;i<size/2;i++)
   b[i] = a[i]*a[size-i];
   return b;
}

int N=13;
int[] a=RandomIntArray(N,1,10);
Print(a);
System.Console.WriteLine();
Print(ProductArray(a));

