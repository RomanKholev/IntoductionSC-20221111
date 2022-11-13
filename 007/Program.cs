//Выяснить является ли число чётным
System.Console.Write("Введите число: ");
double a=Convert.ToDouble(Console.ReadLine());
if (a%2==0)
{
   System.Console.Write($"{a} - Четное число"); 
}
else
{
    System.Console.Write($"{a} - Нечетное число"); 
}