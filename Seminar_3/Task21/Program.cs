//Задача 21
//Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите z2: ");
int z2 = int.Parse(Console.ReadLine());

int sqrX = (x2 - x1) * (x2 - x1);
int sqry = (y2 - y1) * (y2 - y1);
int sqrZ = (z2 - z1) * (z2 - z1);

int sum = sqrX + sqry + sqrZ;

double result = Math.Sqrt(sum);

Console.WriteLine($"A({x1},{y1},{z1});B({x2},{y2},{z2})->{result:f2}");
