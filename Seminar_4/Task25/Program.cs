// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int exponentiation(int arg1, int arg2)
{
  int res = arg1;
  for (int i = 2; i <= arg2; i++)
  {
    res *= arg1;
  }
  return res;
}

Console.WriteLine("Введите число A: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = int.Parse(Console.ReadLine());

Console.WriteLine($"A в степени B = {exponentiation(numA, numB)}");
