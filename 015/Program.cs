﻿// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
System.Console.Write("Введите число: ");
int a=Convert.ToInt32(Console.ReadLine());
int b = (a%100%10);
if (a<100)
{
    System.Console.Write("NO");
}
else
{
System.Console.Write($"Третья цыфра числа: {a} - {b}");
}

