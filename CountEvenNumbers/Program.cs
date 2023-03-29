//Ввести с клавиатуры М чисел. Сколько чисел больше 0?
//{0,7,8,-2,-2} -> 2


void FillArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write("Введите число ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
  }
}

void PrintArray(int[] ar)
{
  foreach (int i in ar)
  {
    Console.Write($"{i},");
  }
  Console.WriteLine();
}

int CountEven(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  if(array[i]>0) count=count+1;
  return count;
}


int[] array = new int[4];
Console.WriteLine(array.Length);
FillArray(array);
PrintArray(array);
Console.WriteLine(CountEven(array));
