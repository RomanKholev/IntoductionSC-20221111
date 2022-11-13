// По заданному с клавиатуры номеру дня недели вывести его название
System.Console.Write("Введите номер дня недели:");
int i=Convert.ToInt32(Console.ReadLine());
if (i > 7)
{
System.Console.Write("В неделе толко 7 дней");
}
else
{
   string[] week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
System.Console.WriteLine($"{i} день недели - {week[i-1]}"); 
}



