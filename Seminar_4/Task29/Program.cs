//Задача 29: Напишите программу, которая задаёт массив из N элементов,
// заполненных случайнми числами из [a, b) и выводит их на экран.
//5, 0, 20 -> [1, 2, 5, 7, 19]
//3, 1, 35 -> [6, 1, 33]

int[] FillArray(int N, int A, int B)
{ 
  int[] array = new int[N];
  var random = new Random();
  for (int i = 0; i < N; i++)
  {
    array[i] = random.Next(A, B);
  }
  return array;
}
Console.Write("Введите число N: ");
int numN = int.Parse(Console.ReadLine());
Console.Write("Введите число A: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine());

int[] arr = FillArray(numN, numA, numB);
Console.WriteLine($"[{String.Join(",", arr)}]");
