// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int CountAboveZero(int[] array)
{
  int res=0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0) res++;
  }
  return res;
}

Console.Write("Введите количество чисел: ");
int size = int.Parse(Console.ReadLine());
int[] newArr = new int[size];
int count = 1;

for (int i = 0; i < size; i++)
{
  Console.Write($"Введите ваше {count} число: ");
  newArr[i] = int.Parse(Console.ReadLine());
  count++;
}
Console.WriteLine($"[{String.Join(" ", newArr)}]");
Console.WriteLine($"Количество чисел >0  ==> {CountAboveZero(newArr)}");
