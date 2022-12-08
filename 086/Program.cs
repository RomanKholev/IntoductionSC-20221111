// Подсчитать сколько раз определенный символ (например 'a') встречается в строке.
// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки
int FindeAndCount(string s, char c)
{
int counter=0;
for (int i = 0; i < s.Length; i++)
    if (s[i]==c) counter++;
return counter;
}

System.Console.WriteLine("Ведите строку");
string s=Console.ReadLine();
System.Console.WriteLine("Ведите искомый символ");
char c=Convert.ToChar(Console.ReadLine());
System.Console.WriteLine($"Символ {c} встречается в строке {FindeAndCount(s,c)} раз"); 


