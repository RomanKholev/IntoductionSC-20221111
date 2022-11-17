// Задать номер четверти, показать диапазоны для возможных координат
System.Console.Write("Введите номер дня четверти: ");
int i=Convert.ToInt32(Console.ReadLine());
while (i>4 || i<0)
{
System.Console.Write("Число от 1 до 4 ");
i=Convert.ToInt32(Console.ReadLine());
}
string[] quter = {"X > 0, Y > 0", "X > 0, Y < 0", "X < 0, Y < 0", "X > 0, Y < 0",};
System.Console.WriteLine($"{i} четверть, координаты: {quter[i-1]}"); 
