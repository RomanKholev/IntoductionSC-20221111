// Написать программу вычисления произведения чисел от 1 до N
double ProductOfNumbers(int a)
{
    double product;
    if (a==0) product=0; else product=1;
for (int i=1;i<=a;i++)
{
   product=product*i; 
}
return product;
}
System.Console.WriteLine("Введите N");
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Произведение чисел от 1 до {n} = {ProductOfNumbers(n)}");
