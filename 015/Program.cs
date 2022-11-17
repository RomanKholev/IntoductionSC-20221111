// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
System.Console.Write("Введите число: ");
int a=Convert.ToInt32(Console.ReadLine());
/*int b = (a/100%10);
if (a<100)
{
    System.Console.Write("NO");
}
else
{
System.Console.Write($"Третья цыфра числа: {a} - {b}");
}
*/
//Вариант 2
if (a>99)
{
    wheil (a>1000)
    {
        a=a/10;
    }
System.Console.WriteLine(a%10);
}
else
{
 System.Console.WriteLine("NO");
}