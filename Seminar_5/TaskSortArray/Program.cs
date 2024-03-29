﻿//Задача "со звездочкой": Разобраться с алгоритмом сортировки 
//методом пузырька. Реализовать невозрастающую сторировку.
//[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
//[1,2,2,3,2] -> [3, 2, 2, 2, 1]

int[] GetArray(int size, int minValue, int maxValue)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(minValue, maxValue + 1);
  }
  return array;
}

void SortArray(int[] array)
{
  for (int i = 0; i < array.Length - 1; i++)
  {
    for (int j = 0; j < array.Length - 1 - i; j++)
    {
      if (array[j] < array[j + 1])
      {
        int temp = array[j];
        array[j] = array[j + 1];
        array[j + 1] = temp;
      }
    }
  }
}

int[] myArray = GetArray(size: 10, minValue: -10, maxValue: 10);
Console.WriteLine($"[{String.Join(", ", myArray)}]");
SortArray(myArray);
Console.Write($"[{String.Join(", ", myArray)}]");
