// найти точку пересечения двух прямых, заданных уравнением y=k*x+b
//по заданным с клавиатуры значениями к1,b1  и  k2,b2
//например при k1=5 b1=2  и  k2=9 b2=4 -> (-0,5;-0,5)

Console.Write($"Задайте значение k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Задайте значение b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write($"Задайте значение k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Задайте значение b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"точка пересечения двух прямых по заданным параметрам ({x}; {y})");
