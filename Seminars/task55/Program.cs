// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


int Prompt(string massege)
{
  Console.Write(massege);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int[,] CreateArray(int m, int n)
{
  int[,] array = new int[m, n];
  return array;
}

void PrintArr(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j],4}  ");
    }
    Console.WriteLine();
  }
}

int[,] FillArrayRandom(int[,] coll)
{
  for (int i = 0; i < coll.GetLength(0); i++)
  {
    for (int j = 0; j < coll.GetLength(1); j++)
    {
      coll[i, j] = new Random().Next(-9, 10);
    }
  }
  return coll;
}

void ReplaceRowsFirstVsLast(int[,] coll)
{
  for (int i = 0; i < coll.GetLength(1); i++)
  {
    for (int j = 0; j < coll.GetLength(0); j++)
    {
      Console.Write($"{coll[j, i],4}  ");
    }
    Console.WriteLine();
  }
}

void Main()
{
  int[,] arr = CreateArray(Prompt("Input M "), Prompt("Input N "));
  arr = FillArrayRandom(arr);
  PrintArr(arr);
  Console.WriteLine();
  ReplaceRowsFirstVsLast(arr);
}

Main();