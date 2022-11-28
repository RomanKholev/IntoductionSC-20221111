// 55 Написать программу масштабирования фигуры

double [] Coordinats (int size=3)
{
    if(size<3) 
    {
      System.Console.WriteLine("Введите координатыт минимум 3 точек:");
      size=3;  
    }
System.Console.WriteLine("Введите координатыт точек:");
int n=size*2;   
double [] a=new double[n];
  int count=0;
 for(int i=0;i<n;i++)
    {
        System.Console.Write($"X{count}=");
        a[i]=Convert.ToDouble(System.Console.ReadLine());  
        i++;
        System.Console.Write($"Y{count}=");
        a[i]=Convert.ToDouble(System.Console.ReadLine());
        count++;  
    }
        
    
return a;
}

double [] Scale (double [] a, double K=1)
{
    int size=a.Length;
double [] b=new double[size];
    b[0]=a[0];        
    b[1]=a[1];
    for(int i=2;i<a.Length;i++)
    b[i]=a[i]*K;
return b;
}  



void PrintPoint(double[] a)
{
    int count=0;
        for(int i=0;i<a.Length;i++)
        {
        System.Console.Write($"X{count}={a[i],3}  ");
        i++;
        System.Console.Write($"Y{count}={a[i],3} | ");
        count++;
        }
}
System.Console.WriteLine("Введите количество точек фигуры: ");
int N=Convert.ToInt32(System.Console.ReadLine()); 
System.Console.WriteLine("Введите коэффициент масштабирования: ");
double K=Convert.ToDouble(System.Console.ReadLine());    
while (K==0)
{
System.Console.WriteLine("Введите коэффициент масштабирования отличный от 0: ");
K=Convert.ToDouble(System.Console.ReadLine());    
}
  
double [] a=Coordinats(N);
System.Console.WriteLine("Координаты точек исхожной фигуры: ");
PrintPoint(a);
System.Console.WriteLine();
System.Console.WriteLine("Координаты точек фигуры после масштабирования: ");
PrintPoint(Scale(a, K));