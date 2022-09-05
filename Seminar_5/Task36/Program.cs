//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] GetFillArray(int size, int minValue, int maxValue)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(minValue, maxValue + 1);
  }
  return array;
}

int SumOfOdd(int[] array)
{
  int result = 0;
  for (int i = 1; i < array.Length; i += 2)
  {
    result += array[i];
  }
  return result;
}

int[] myArray = GetFillArray(size: 10, minValue: -10, maxValue: 10);
Console.WriteLine($"[{String.Join(", ", myArray)}]");
Console.Write($"Сумма значений нечетных позиций в массиве равна {SumOfOdd(myArray)}");
