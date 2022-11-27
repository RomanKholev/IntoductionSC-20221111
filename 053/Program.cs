// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
string CrossLine(double k1, double k2, double b1, double b2)
{
string resolt;
double x1=1, x2=10; 
double y11=k1*x1+b1;
double y12=k1*x2+b1;
double y21=k2*x1+b2;
double y22=k2*x2+b2;
double A1 = y12-y11; 
double B1 = x1-x2;
double C1 = -x1*y12+y11*x2; 
double A2 = y22-y21; 
double B2 = x1-x2; 
double C2 = x1*y22+y21*x2;
double x = (B1 * C2 - B2 * C1) / (A1 * B2 - A2 * B1);
double y = (A2 * C1 - A1 * C2) / (A1 * B2 - A2 * B1);
if ((A1 * B2 - A2 * B1) == 0) resolt=("Прямые паралельны");
    else resolt=($"Кординаты точки пересечения х={x}, у={y}");
    return resolt;
}
double k1=10;
double k2=12;
double b1=1;
double b2=10;
System.Console.WriteLine(CrossLine(k1, k2, b1, b2));
