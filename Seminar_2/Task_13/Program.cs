//Задача 13: Напишите программу, которая выводит третью цифру (справа налево) 
//заданного числа или сообщает, что третьей цифры нет.
//645   -> 6
//78    -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int result;
if (99 < num)
{
  result = num / 100 % 10;
  Console.WriteLine($"{num} -> {result}");
}
else
{
  Console.WriteLine("Третьей цифры нет");
}
