// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"\t{array[i, j]} ");
    }
    Console.WriteLine();
  }
}

void AveregeColumValue(int[,] array)
{
  for (int i = 0; i < array.GetLength(1); i++)
  {
    double sum = 0;
    double count = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
      sum += array[j, i];
      count++;
    }
    double averegeValue = sum / count;
    Console.Write($"\t{averegeValue:f1} ");
  }
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine());
int[,] myArray = new int[row, col];
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();
AveregeColumValue(myArray);
