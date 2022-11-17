// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
int a;
do
{
  System.Console.Write("Введите число в диапозон от 10 до 99: ");
a=Convert.ToInt32(Console.ReadLine());  
} 
while (a<10 || a>99);

int num1 = (a/10);
int num2 = (a%10);
int max = num1;
if (max < num2)
{
    max = num2;
} 
System.Console.WriteLine($"Наибольшая цифра: {max}");
