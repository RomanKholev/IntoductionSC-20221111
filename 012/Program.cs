// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
System.Console.Write("Введите число в диапозон от 10 до 99: ");
int a=Convert.ToInt32(Console.ReadLine());
int num1 = (a/10);
int num2 = (a%10);
int max = num1;
if (max < num2)
{
    max = num2;
} 
System.Console.WriteLine($"Наиборльшая цифра: {max}");
