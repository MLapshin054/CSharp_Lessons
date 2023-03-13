// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int Prompt(string message)
{
  Console.Write(message);
  var readInput = Console.ReadLine();
  int result = Convert.ToInt32(readInput);
  return result;
}

int[,] CreatArray(int m = 3, int n = 4)
{
  int[,] matrix = new int[m, n];
  return matrix;
}

void PrintArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
  }
}

int[,] FillArrayRandom(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(1, 20);
    }
  }
  return arr;
}

string FindNumber(int[,] matr)
{
  int findNum = Prompt("Введите число для поиска: ");
  string result = string.Empty;

  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      if (matr[i, j] == findNum)
      {
        result = result + $" {findNum} на позиции [{i}, {j}]";
      }
    }
  }
  return result == "" ? $"{findNum} нет в матрице" : result;
}

int[,] matr = CreatArray();
matr = FillArrayRandom(matr);
PrintArray(matr);
Console.WriteLine(FindNumber(matr));