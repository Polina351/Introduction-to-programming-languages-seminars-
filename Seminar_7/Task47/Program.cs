//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//  0,5  7    -2  -0,2
//  1   -3,3   8  -9,9
//  8   7,8   -7,1  9

void FillDoubleRandomArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(-9, 10) + new Random().NextDouble();
    }
  }
}

void PrintArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"\t{array[i, j]:f1}");
    }
    Console.WriteLine();
  }
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine());
double[,] myArray = new double[row, col];
FillDoubleRandomArray(myArray);
PrintArray(myArray);
