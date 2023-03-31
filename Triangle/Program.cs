// Ввести 3 целых положительных числа. 
//Является ли это сторонами треугольника?
//Если да, то вывести площадь, периметр, значения углов в градусахб является ли прямоугольным, равнобедренным, равносторонним

Console.Write($"введите число a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"введите число b ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write($"введите число c ");
int c = Convert.ToInt32(Console.ReadLine());

bool Triangle(int a, int b, int c)
{
  if ((a + b > c) && (a + c > b) && (b + c > a))
    //Console.WriteLine(true);
    return true;
  else return false;//Console.WriteLine(false);
}

Double Area(double s)
{
  int hypot = a; int cat1 = b; int cat2 = c;
  if (b > a && b > c)
  {
    hypot = b; cat1 = a; cat2 = c;
  }
  if (c > a && c > b)
  {
    hypot = c; cat1 = a; cat2 = b;
  }
  //int h = (cat1 * cat2) / hypot;
  s = (double)(cat1 * cat2) / 2; //1 / 2 * hypot * h;
  return s;
}

int Perimeter(int p)
{
  p = a + b + c;
  return p;
}

void Angle(double ang)
{
  double hypot = a; double cat1 = b; double cat2 = c;
  if (b > a && b > c)
  {
    hypot = b; cat1 = a; cat2 = c;
  }
  if (c > a && c > b)
  {
    hypot = c; cat1 = a; cat2 = b;
  }
  double alfa = Math.Round(Math.Acos((cat1 * cat1 + hypot * hypot - cat2 * cat2) / (2 * cat1 * hypot)) * 180 / Math.PI);
  double beta = Math.Round(Math.Acos((cat2 * cat2 + hypot * hypot - cat1 * cat1) / (2 * cat2 * hypot)) * 180 / Math.PI);
  double gamma = Math.Round(Math.Acos((cat2 * cat2 + cat1 * cat1 - hypot * hypot) / (2 * cat2 * cat1)) * 180 / Math.PI);

  Console.WriteLine($"угол alfa = {alfa}");
  Console.WriteLine($"угол beta = {beta}");
  Console.WriteLine($"угол gamma = {gamma}");
}

void Type(int t)
{
  int hypot = a; int cat1 = b; int cat2 = c;
  if (b > a && b > c)
  {
    hypot = b; cat1 = a; cat2 = c;
  }
  if (c > a && c > b)
  {
    hypot = c; cat1 = a; cat2 = b;
  }
  if (cat1 == cat2 && cat2 == hypot)
  {
    Console.WriteLine($"Треугольник равносторонний");
  }
  if (cat1 == cat2 && cat2 != hypot)
   {
    Console.WriteLine($"Треугольник равнобедренный");
  }
  if (cat1 * cat1 + cat2 * cat2== hypot*hypot)
   {
    Console.WriteLine($"Треугольник прямоугольный");
  }
  if (cat1 * cat1 + cat2 * cat2< hypot*hypot)
   {
    Console.WriteLine($"Треугольник тупой");
  }
  if (cat1 * cat1 + cat2 * cat2> hypot*hypot)
   {
    Console.WriteLine($"Треугольник острый");
  }
}

bool res = Triangle(a, b, c);
Console.WriteLine(res);
if (res == true)
{
  double s = Area(a);
  Console.WriteLine($"площадь треугольника = {s}");
  int p = Perimeter(a);
  Console.WriteLine($"периметр треугольника = {p}");
  Angle(a);
  Type(a);
}

