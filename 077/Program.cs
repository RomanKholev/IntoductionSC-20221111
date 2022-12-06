// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности 0 и 1 

int Fibonacci(int n)
    {
    if (n == 0 || n == 1) return n;
    else
       return Fibonacci(n - 1) + Fibonacci(n - 2);  
    } 

void PrintFibonacci (int n)
{
for (int i = 0; i < n; i++)
{
 System.Console.Write($"{Fibonacci(i), 5}");
}   
}

System.Console.WriteLine("Введите N");  
int n=Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(); 
PrintFibonacci(n);

