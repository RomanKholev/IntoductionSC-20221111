// 88. Заменить все вхождения подстроки w в строке st на строку v. Вывести на экран первоначальную строку и конечную строку
System.Console.WriteLine("Введите строку"); 
string st=Console.ReadLine();
System.Console.WriteLine("Введите подстроку для замены"); 
string w=Console.ReadLine();
System.Console.WriteLine("Введите на что меняем"); 
string v=Console.ReadLine();

System.Console.WriteLine(st);
string st1;
st1=st.Replace(w,v);
System.Console.WriteLine(st1);

