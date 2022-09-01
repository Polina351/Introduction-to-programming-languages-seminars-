//Задача 27: Напишите программу, которая принимает на 
//вход число и выдаёт сумму цифр в числе.
//452   -> 11
//82    -> 10
//9012  -> 12

int SumOfNum(int num)
{
  int result = 0;
  while (num >= 10)
  {
    int summand = num % 10;
    num = num / 10;
    result += summand;
  }
  if (num < 10) result += num;
  return result;
}
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа{number} = {SumOfNum(number)}");
