//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом. Строки и массивы использовать нельзя!

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if (9999 < num && num < 100000)
{
  int leftRes = (((num / 10000) * 10) + (num / 1000 % 10));
  int rightRes = (((num % 10) * 10) + ((num / 10) % 10));
  if (leftRes == rightRes)
  {
    Console.WriteLine($"{num} ->является палиндромом");
  }
  else Console.Write($"{num} ->не является палиндромом");
}
else Console.Write("Введено некорректное значение");
