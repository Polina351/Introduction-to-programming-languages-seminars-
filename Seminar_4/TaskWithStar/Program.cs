//Задача “со звездочкой”: Напишите функцию, которая принимает одно 
//число - высоту елочки и рисует ее в консоли звездочками.

void Triangle(int num)
{
  int a = 0;

  for (int i = num; i > 0; i--)
  {
    for (int j = 0; j < i; j++)
    {
      Console.Write(" ");
    }
    for (int k = 0; k <= a * 2; k++)
    {
      Console.Write("*");
    }

    Console.WriteLine();
    a++;
  }
}

Console.WriteLine("Введите высоту елочки: ");
int height = int.Parse(Console.ReadLine());

Console.Clear();
Triangle(height);
