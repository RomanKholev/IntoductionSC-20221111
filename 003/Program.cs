// С клавиатуры вводятся два числа a и b. Найти максимальное из них.
System.Console.Write("Введите число а:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите число с:");
double c=Convert.ToDouble(Console.ReadLine());
double max = a;
if (max < b)
{
    max = b;
} 
if (max < c) 
{
    max = c;
}
System.Console.WriteLine($"{max} является иаксимальным");