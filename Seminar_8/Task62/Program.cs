// Задача 62. Напишите программу, которая заполнит 
//спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

void FillSpiralArray(int[,] array)
{
  int startRow = 0;
  int endRow = array.GetLength(0) - 1;
  int startCol = 0;
  int endCol = array.GetLength(1) - 1;
  int count = 1;
  int maxCount = array.GetLength(0) * array.GetLength(1);
  while (startRow <= endRow && startCol <= endCol)
  {
    for (int i = startCol; i <= endCol; i++)
    {
      array[startRow, i] = count++;
      if (count > maxCount) return;
    }
    startRow++;
    for (int j = startRow; j <= endRow; j++)
    {
      array[j, endCol] = count++;
      if (count > maxCount) return;
    }
    endCol--;
    for (int k = endCol; k >= startCol; k--)
    {
      array[endRow, k] = count++;
      if (count > maxCount) return;
    }
    endRow--;
    for (int m = endRow; m >= startRow; m--)
    {
      array[m, startCol] = count++;
      if (count > maxCount) return;
    }
    startCol++;
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

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine());
int[,] myArray = new int[row, col];
FillSpiralArray(myArray);
PrintArray(myArray);
