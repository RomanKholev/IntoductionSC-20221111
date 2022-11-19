// Найти сумму чисел от 1 до А
System.Console.WriteLine("Введите A");
int a=Convert.ToInt32(Console.ReadLine());
int SumNumbers(int a)
{
    int b=0;
for (int i=1;i<=a;i++)
{
   b=b+i; 
}
return b;
}
System.Console.WriteLine($"Сумму чисел от 1 до {a} = {SumNumbers(a)}");
