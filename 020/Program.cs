// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
System.Console.WriteLine("Введите координаты X и Y, причем X и Y не равны 0");
double x,y; 
x=Convert.ToDouble(Console.ReadLine());
y=Convert.ToDouble(Console.ReadLine());
if (x==0 && y==0) System.Console.WriteLine("Введите координаты X и Y не равные 0");
if (x>0&&y>0) System.Console.WriteLine("Координаты в 1-й четверти");
if (x<0&&y>0) System.Console.WriteLine("Координаты в 2-й четверти");
if (x<0&&y<0) System.Console.WriteLine("Координаты в 3-й четверти");
if (x>0&&y<0) System.Console.WriteLine("Координаты в 4-й четверти");