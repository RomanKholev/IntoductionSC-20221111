﻿/*
Напишите программу для решения следующей задачи. 
На  контрольной  работе  по  алгебре  ученикам 9 класса  было  предложено 
10 примеров.  Неудовлетворительная  оценка  выставляется,  если  правильно 
решено  менее  половины  примеров.  Сколько  неудовлетворительных  оценок 
было получено учениками? Если хотя бы один из учеников правильно решил 
все задачи, выведите YES, иначе – выведите NO. 
Программа получает на вход количество учеников в классе N (1 ≤ N ≤ 30), 
затем  для  каждого  ученика  вводится  количество  правильно  решённых 
примеров.
*/


int n=Convert.ToInt32(Console.ReadLine());
int k=0;//Счетчик
bool flag=false;//флаг
for(int i=0;i<n;i++)
{
    int a=Convert.ToInt32(Console.ReadLine());
    if (a<5) k++;
    if (a==10) flag=true;
}
System.Console.WriteLine(k);
if (flag) System.Console.WriteLine("YES"); else System.Console.WriteLine("NO");