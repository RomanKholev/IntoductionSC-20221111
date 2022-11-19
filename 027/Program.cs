// Возведите число А в натуральную степень B используя цикл
System.Console.WriteLine("Введите A");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите B");
int b=Convert.ToInt32(Console.ReadLine());

double Degree(double a, int b)
{
    double result=a;
for (int i=1;i<b;i++)
{
   result=result*a; 
}
return result;
}
System.Console.WriteLine($"{a}^{b}={Degree(a,b)}");
