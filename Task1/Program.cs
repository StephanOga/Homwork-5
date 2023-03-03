 /*  Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
 [345, 897, 568, 234] -> 2
 */

void FillArray(int[] numbers)
{
  int length = numbers.Length;
  for (int i = 0; i < length; i++)
  {
    numbers[i] = new Random().Next(100, 999);
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

static int GetEven(int[] even)
{
  int length = 0;
  for (int index = 0; index < even.Length; index++)
  {
    if (even [index] % 2 == 0) // находим четное число
    {
      length++;
    }
  }
  return length;
}

int[] array = new int[4];


FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел = {GetEven(array)}");
