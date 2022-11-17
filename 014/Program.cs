// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
System.Console.WriteLine("Введите число а:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
double multiplicity = a / b;
System.Console.WriteLine(multiplicity);
if (multiplicity%1 == 0)
{
   System.Console.Write("Число a кратно числу b:"); 
}
else 
{
double remainder = (a%b);
System.Console.WriteLine($"Остаток от деления a на b = {remainder}");
}