using System.Transactions;
using System.Security;
using Microsoft.CSharp.RuntimeBinder;
/*
int a=0, b=1, c=2; // целый 32 бита
float f=2.04f; // вещ 32 бита
double d=3.14; //веществ 64 бита
string s="Текст" //Строака
char c0='a' //Один символ в ' ' 
bool flag=true // true или falsh
*/
// 1. С клавиатуры вводится целое число. Вывести квадрат числа 
int a;
System.Console.WriteLine("Введите число: ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
int b=a*a;
System.Console.WriteLine(Convert.ToString(a)+"^2="+b.ToString());
