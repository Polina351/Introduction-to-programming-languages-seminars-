﻿//Задача 23
//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
  double cube = Math.Pow(i, 3);
  Console.Write($"{cube} ");
}
