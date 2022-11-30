//67 Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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
        System.Console.Write($"{a[i,j],7}");
           System.Console.WriteLine();
        }
}

double [] AverageOfСolumn(int[,] a)
{
double sum=0;
double[] averagesum=new double[a.GetLength(1)]; 
    for(int j=0;j<a.GetLength(1);j++)
        {
            sum=0;
            for(int i=0;i<a.GetLength(0);i++)
            {
            sum=sum+a[i,j];
            }
            
        averagesum[j]=sum/a.GetLength(0); 
        }
        
return averagesum;
}

void PrintArray(double[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],7}");
}

System.Console.WriteLine("Введите размерность двумерного массива M и N");
int n=Convert.ToInt32(System.Console.ReadLine());
int k=Convert.ToInt32(System.Console.ReadLine());  
int [,] a=Random2DArray(n, k,0,10);
Print2DArray(a); 
System.Console.WriteLine();
PrintArray(AverageOfСolumn(a));

