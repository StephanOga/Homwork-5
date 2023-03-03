/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

void FillArray(int[] numbers)
{
  int length = numbers.Length;
  for (int i = 0; i < length; i++)
  {
    numbers[i] = new Random().Next(1, 99);
  }
}

void PrintArray(int[] numb)
{
  int k = numb.Length;
  for (int index = 0; index < k; index++)
  {
    Console.WriteLine(numb[index]);
  }
}

static int SumNoEven(int[] even)
{
  int sum = 0;
  for (int index = 0; index < even.Length; index++)
  {
    if (even [index] % 2 != 0)  //- yf[jlbv yt xtnyjt]
    {
      sum = sum + even [index];
    }
  }
  return sum;
}

int[] array = new int[4];


FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма всех нечетных чисел = {GetSumNoEven(array)}");