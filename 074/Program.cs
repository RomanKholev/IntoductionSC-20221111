// Найти сумму цифр числа
 int SumDigit(int N)
{
    if (N==0) return 0;
     else
       return SumDigit(N/10)+N%10;
}
System.Console.WriteLine("Введите число N");
int n=Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(SumDigit(n));