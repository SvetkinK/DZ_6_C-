// Задать число. Составить массив чисел НегаФибоначчи, в т.ч. и для отрицательных индексов.
// например для k=9 массив {-21,13,-8,5,-3,2,-1,1,0,1,1,2,3,5,8,13,21}

Console.Write($"Задайте значение k ");
int k = Convert.ToInt32(Console.ReadLine());
int[] NF = new int[k * 2 - 1];

int i = k - 1;
NF[i] = 0;
for (i = k - 2; i >= 0; i--)
{
  if (i == k - 2) NF[i] = 1;
  else
    NF[i] = NF[i + 1] * -1 + NF[i + 2];
  if (i == 0)
  {
    for (i = 0; i <= k - 1; i++)
    {
      Console.Write($"{NF[i]}, ");
    }
    i = 0;
  }
}
for (i = k; i <= k * 2 - 2; i++)
{
  if (i == k)
  {
    NF[i] = 1;
  }
  else
  {
    NF[i] = NF[i - 1] + NF[i - 2];
  }
  Console.Write($"{NF[i]}, ");
}





// double Fibonacci(int n)
// {
//    if( n== 1 || n == 2) return 1;
//    else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }

// for (int i=0; i<10; i++)
// {
//    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }
