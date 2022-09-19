//Задача 58: Задайте две матрицы. Напишите программу,
//которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

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

int[,] MatrixProduct(int[,] matrixRow, int[,] matrixCol)
{
  int resultRow = matrixRow.GetLength(0);
  int resultCol = matrixCol.GetLength(1);
  int[,] result = new int[resultRow, resultCol];
  for (int i = 0; i < resultRow; i++)
  {
    for (int j = 0; j < resultCol; j++)
    {
      result[i, j] = 0;
      for (int k = 0; k < matrixCol.GetLength(0); k++)
      {
        result[i, j] = result[i, j] + matrixRow[i, k] * matrixCol[k, j];
      }
    }
  }
  return result;
}

int[,] rowArray = new int[,]
{
  {3,2,2},
  {4,1,2},
  {3,4,1},
};
int[,] colArray = new int[,]
{
  {1,2},
  {1,4},
  {3,2},
};

if (rowArray.GetLength(1) == colArray.GetLength(0))
{
  int[,] resulArray = MatrixProduct(rowArray, colArray);
  PrintArray(resulArray);
}
else Console.WriteLine("Выполнение невозможно!");
