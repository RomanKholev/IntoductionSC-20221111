// С клавиатуры вводятся два числа a и b. Найти максимальное из них.
System.Console.Write("Введите число а:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
double max = a;
if (max < b)
{
    max = b;
}
System.Console.WriteLine($"{max} является иаксимальным");