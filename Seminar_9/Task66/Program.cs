//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке 
//от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumElements(int M, int N)
{
  if (M <= N) return M + SumElements(M + 1, N);
  return 0;
}

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.Write(SumElements(m, n));
