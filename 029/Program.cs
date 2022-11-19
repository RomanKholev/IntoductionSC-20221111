// Подсчитать сумму цифр в числе. Сделать подпрограмму.
int SumOfNumbers (int a)
{
    int sum=0;
    while (a>=1)
    {
     sum = sum+a%10;
     a=a/10;
    }
    
return sum;
}
System.Console.WriteLine("Введите A");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumOfNumbers(a));
