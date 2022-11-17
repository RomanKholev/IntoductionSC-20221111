// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
System.Console.WriteLine("Введите число обозначающее день недели");
int n=Convert.ToInt32(Console.ReadLine());
while (n>7||n<1)
{
    System.Console.WriteLine("В неделе 7 дней");
n=Convert.ToInt32(Console.ReadLine()); 
}
    if (n>5) {
    System.Console.WriteLine("Выходной");
}
else System.Console.WriteLine("Будний");

