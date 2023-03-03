/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.

[3 7 22 2 78] -> 76
*/


void FillArray(double[] numbers)
{
  int length = numbers.Length;
  for (int i = 0; i < length; i++)
  {
    numbers[i] = new Random().Next(1, 1999) / 10.0;
  }
}

void PrintArray(double[] numb)
{
  int k = numb.Length;
  for (int index = 0; index < k; index++)
  {
    Console.Write($" {numb[index]} ;");
  }
}

double[] array = new double[6];

FillArray(array);
PrintArray(array);

  double Max = array[0];
  double Min = array[0];
  int l = array.Length;
  for (int index = 0; index < l; index++)
  {
    if (array[index] > Max)
    {
      Max = array[index];
    }
    if (array[index] < Min)
    {
      Min = array[index];
    }
  }


Console.WriteLine();

Console.WriteLine($"Максимальное число = {Max}");
Console.WriteLine($"Минимальное число = {Min}");
Console.WriteLine("Разность между максимальным и минимальным числом =  " + (Max - Min)); 