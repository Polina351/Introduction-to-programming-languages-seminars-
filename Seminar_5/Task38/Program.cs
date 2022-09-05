//Задача 38: Задайте массив вещественных чисел. Найдите разницу 
//между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] FillArray(int size, int minValue, int maxValue)
{
  double[] resault = new double[size];
  for (int i = 0; i < size; i++)
  {
    resault[i] = new Random().Next(minValue, maxValue + 1);
  }
  return resault;
}

double FindMin(double[] array)
{
  double minVal = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if (array[i] < minVal) minVal = array[i];
  }
  return minVal;
}

double FindMax(double[] array)
{
  double maxVal = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if (array[i] > maxVal) maxVal = array[i];
  }
  return maxVal;
}

double[] myArray = FillArray(size: 10, minValue: -10, maxValue: 10);
Console.WriteLine($"[{String.Join(", ", myArray)}]");
double difMaxMin = FindMax(myArray) - FindMin(myArray);
Console.WriteLine($"Разница между максимальным({FindMax(myArray)}) и минимальным({FindMin(myArray)}) значением равна {difMaxMin}");
