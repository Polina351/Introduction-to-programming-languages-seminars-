//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine());
if (0 < num && num < 8)
  if (num == 6 || num == 7)
  {
    Console.WriteLine($"{num} -> Да");
  }
  else
  {
    Console.WriteLine($"{num} -> Нет");
  }
else
{
  Console.WriteLine("Некорректное значение!");
}
