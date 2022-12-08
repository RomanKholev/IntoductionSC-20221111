// See https://aka.ms/new-console-template for more information
char c='a'; //char задаеся в одинарных ковычках
c='\x0064';  //код в колдировке
c='\u0064'; //код в кодировке Unicod
char b='a';
System.Console.WriteLine((int)b);
System.Console.WriteLine(c.ToString()+b.ToString()); //crktbn d cnhjre
if (b>='0' && b<='9') System.Console.WriteLine("It's digit");
if (b>='A' && b<='Z') System.Console.WriteLine("It's big Latin");
if (b>='a' && b<='z' || b>='A' && b<='Z') System.Console.WriteLine("It's big Latin");

if (Char.IsDigit(b)) System.Console.WriteLine("It's digit");


string s="asdf";
//immytabel string (неизменяемые строки)
System.Console.WriteLine(s[0]);
for (int i=0; i< s.Length; i++)
{
System.Console.WriteLine(s[i]); 
}
char [] cc=s.ToCharArrey();
cc[]='S'
s=new String(cc);

System.Text.StringBuilder sb=new System.Text.StringBuilder("sdsds")
sb[0]='S'
s=sb.ToString;
