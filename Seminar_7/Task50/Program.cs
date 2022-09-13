//Задача 50. Напишите программу, которая на вход принимает число
// и генерирует случайный двумерный массив, и возвращает индексы 
//этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void PositionValue(int row, int col, int[,] array)
{
  int maxRow = array.GetLength(0) - 1;
  int maxCol = array.GetLength(1) - 1;
  if (0 <= row && row <= maxRow && 0 <= col && col <= maxCol)
  {
    Console.WriteLine($"({row};{col}) ==>{array[row, col]}");
  }
  else Console.WriteLine($"Позиции ({row};{col}) не существует");
}

int[,] myArray = new int[,]
{
  {1,7,4,8,3},
  {4,1,9,5,8},
  {3,7,5,3,7},
  {2,5,4,9,5},
};

Console.Write("Введите значение Х: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите значение Y: ");
int y = int.Parse(Console.ReadLine());
PositionValue(x, y, myArray);