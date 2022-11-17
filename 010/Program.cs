// Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
System.Console.Write("Введите число: ");
int a=Convert.ToInt32(Console.ReadLine());
int b = (a%10);
System.Console.Write($"Последняя цифра числа: {a} - {b}");
