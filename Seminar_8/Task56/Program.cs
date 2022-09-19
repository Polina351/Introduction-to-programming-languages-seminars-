//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с 
//наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}

int[] StringSumArray(int[,] array)
{
  int[] sumArray = new int[array.GetLength(0)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum += array[i, j];
      sumArray[i] = sum;
    }
  }
  return sumArray;
}

void PrintStringMinSumValue(int[] array)
{
  int minPosition = 0;
  for (int i = 0; i < array.Length - 1; i++)
  {
    if (array[minPosition] > array[i + 1])
    {
      minPosition = i+1;
    }
  }
  Console.WriteLine($"{minPosition+1}-я строка с наименьшей суммой элементов");
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine());
int[,] myArray = new int[row, col];
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();
int[]sumArray=StringSumArray(myArray);
Console.WriteLine($"{String.Join(" ",sumArray)}");
PrintStringMinSumValue(sumArray);
