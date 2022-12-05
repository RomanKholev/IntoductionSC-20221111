// 75. Написать программу вычисления функции Аккермана - 5*

double Akkerman(double n, double m)
{  
     if (n == 0) return m + 1;
         else 
            if (n > 0 && m == 0) return Akkerman(n - 1, 1);
                else
                   if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));
                         else return 0;
}
System.Console.WriteLine("Введите M");
double m=Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Введите N");
double n=Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine($"Значение функции Аккермана A({m},{n})={Akkerman(m,n)}");
