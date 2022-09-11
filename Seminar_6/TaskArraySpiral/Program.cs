//Напишите программу, которая обходит двумерный массив против часовой 
//стрелки, начиная с  крайнего нижнего левого элемента.
//1 2 3
//4 5 6 -> 7 8 9 6 3 2 1 4 5
//7 8 9

int[] ArraySpiralTravers(int[,] array)
{
  int startRow = 0;
  int endRow = array.GetLength(0) - 1;
  int startCol = 0;
  int endCol = array.GetLength(1) - 1;
  int size = array.GetLength(0) * array.GetLength(1);
  int[] newarray = new int[size];
  int count = 0;

  while (startRow <= endRow && startCol <= endCol)
  {
    for (int i = startCol; i <= endCol; i++)
    {
      if (count < size)
        newarray[count] = array[endRow, i];
      count++;
    }
    endRow--;
     for (int j = endRow; j >= startRow; j--)
    {
      if (count < size)
        newarray[count] = array[j, endCol];
      count++;
    }
    endCol--;
    for (int k = endCol; k >= startCol; k--)
    {
      if (count < size)
        newarray[count] = array[startRow, k];
      count++;
    }
    startRow++;
     for (int m = startRow; m <= endRow; m++)
    {
      if (count < size)
        newarray[count] = array[m, startCol];
      count++;
    }
    startCol++;
  }
  return newarray;
}

int[,] GetArray()
{
  Console.Write("Количество строк: ");
  int row = int.Parse(Console.ReadLine());
  Console.Write("Количество столбцов: ");
  int col = int.Parse(Console.ReadLine());
  int[,] array = new int[row, col];
  int count = 1;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = count;
      count++;
    }
  }
  return array;
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

int[,] oldArray = GetArray();
PrintArray(oldArray);
Console.WriteLine();
int[] newArray = ArraySpiralTravers(oldArray);
Console.WriteLine($"[{String.Join(" ", newArray)}]");
