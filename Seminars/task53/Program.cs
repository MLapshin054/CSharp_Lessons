// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

int Prompt(string message)
{
  System.Console.Write(message);
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
      System.Console.Write($"{array[i, j],4}  ");
    }
    System.Console.WriteLine();
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


int[,] ReplaceRowsFirstVsLast(int[,] coll)
{
  int temp;
  for (int i = 0; i < coll.GetLength(0); i++)
  {
    for (int j = 0; j < coll.GetLength(1); j++)
    {
      temp = coll[0, j];
      coll[0, j] = coll[coll.GetLength(1) - 1, j];
      coll[coll.GetLength(1) - 1, j] = temp;
    }
  }
  return coll;
}

void Main()
{
  int[,] arr = CreateArray(Prompt("Введите m: "), Prompt("Введите n: "));
  arr = FillArrayRandom(arr);
  PrintArr(arr);
  Console.WriteLine();
  PrintArr(ReplaceRowsFirstVsLast(arr));
}

Main();