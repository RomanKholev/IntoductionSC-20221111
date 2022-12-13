// Задача 93: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int [,]ProductSymmetricalMatrix (int [,] a1 , int [,] a2)
{
    int [,] p=new int[a1.GetLength(0), a1.GetLength(1)]; 
        for(int i=0;i<a1.GetLength(0);i++)
        {
        
            for(int j=0;j<a1.GetLength(1);j++)
                p[i,j]=a1[i,j]*a2[i,j]; 
        }
return p;
}

int [,] a1 = Random2DArray(3,4,1,10);
int [,] a2 = Random2DArray(3,4,1,10);
int [,] p = ProductSymmetricalMatrix(a1,a2);
Print2DArray(a1);
System.Console.WriteLine();
Print2DArray(a2);
System.Console.WriteLine();
Print2DArray(p);