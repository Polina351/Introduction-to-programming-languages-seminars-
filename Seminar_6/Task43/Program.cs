//Задача 43: Напишите программу, которая найдёт точку пересечения 
//двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// k1 = 5, b1 = 2, k2 = 9, b2 = 4-> (-0,5; -0,5)

void PointIntersection(int k1, int b1, int k2, int b2)
{
  double rightRes = -b1 + b2; //решение правой части урaвнения
  double x = rightRes / (k1 - k2);
  double y = k1 * x + b1;
  Console.WriteLine($"Точка пересечения  двух прямых имеет кооординаты({x:f1};{y:f1})");
}

Console.WriteLine("y= k1*x+b1;  y= k2*x+b2");
Console.Write("Введите значение k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение k2: ");
int k2 = int.Parse(Console.ReadLine());
Console.Write("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine());

if (k1 != k2) 
PointIntersection(k1, b1, k2, b2);
else Console.WriteLine("Угловые коэффициенты уравнений равны => прямые параллельны");
