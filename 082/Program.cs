// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки
int FindeAndCount(string s="пример.пример")
{
char [] ca=s.ToCharArray();
int counter=0;
for (int i = 0; i < ca.Length; i++)
{
if (ca[i]=='.') break;
  counter++;  
}
if (counter==ca.Length) counter=-1;
return counter;
}

System.Console.WriteLine("Ведите строку разделенную точкой");
string s=Console.ReadLine();
if (FindeAndCount(s)<0) System.Console.WriteLine($"В строке нет точки");
    else System.Console.WriteLine($"До точки {FindeAndCount(s)} символов");


