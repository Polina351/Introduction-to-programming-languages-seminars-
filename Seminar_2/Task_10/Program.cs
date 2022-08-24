// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехначное число: ");
int num = int.Parse(Console.ReadLine());
int result;
if (99 < num && num < 1000)
{
 result = num / 10 % 10;
 Console.WriteLine($"{num} -> {result}");
}
else
{
  Console.WriteLine("Введено некорректное значение!");
}