//Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
//числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void FillArray(int[] array, int minValue, int maxValue)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(minValue, maxValue);
  }
}

int PositiveCount(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    {
      count += 1;
    }
  }
  return count;
}

int[] myArr = new int[10];
FillArray(myArr, 100, 1000);
Console.WriteLine($"[{String.Join(",", myArr)}]");
Console.WriteLine($"В массиве {PositiveCount(myArr)} четных элементa(ов)");
