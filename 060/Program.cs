﻿// Показать двумерный массив размером m×n заполненный целыми случайными числами
int[,] Random2DArray(int n,int m,int min=0,int max=10)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}

System.Console.WriteLine("Введите размерность двумерного массива M и N");
int M=Convert.ToInt32(System.Console.ReadLine());
int N=Convert.ToInt32(System.Console.ReadLine());  
int [,] a=Random2DArray(M, N,0,100);
Print2DArray(a); 