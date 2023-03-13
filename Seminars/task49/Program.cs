// Задача 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса четные,
// и замение эти элементы на их квадраты.

// void PrintArray(double[,] matr)
// {
//   for (int i = 0; i < matr.GetLength(0); i++)
//   {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//       Console.Write($"{matr[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }

// void FillArray(double[,] matr)
// {
//   for (int i = 0; i < matr.GetLength(0); i++)
//   {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//       matr[i, j] = new Random().Next(1, 10);
//     }
//   }
// }

// void FindSquare(double[,] matr)
// {
//   for (int i = 0; i < matr.GetLength(0); i++)
//   {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//       if (i % 2 == 0 && j % 2 == 0)
//       {
//         matr[i, j] = Math.Pow(matr[i, j], 2);
//       }
//     }
//   }
// }

// double[,] matrix = new double[3, 3];

// PrintArray(matrix);
// Console.WriteLine();
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// FindSquare(matrix);
// PrintArray(matrix);

int Prompt(string message)
{
  System.Console.WriteLine(message);
  var readInput = Console.ReadLine();
  int result=Convert.ToInt32(readInput);
  return result;
}

int[,] CreateArray(int m, int n)
{
  int[,] array = new int[m, n];
  return array;
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j],4} ");
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

int[,] FillArray(int[,] coll)
{
  for (int i = 0; i < coll.GetLength(0); i += 2)
  {
    for (int j = 0; j < coll.GetLength(1); j += 2)
    {
      coll[i, j] *= coll[i, j];
    }
  }
  return coll;
}

int[,] arr = CreateArray(Prompt("Введите m: "), Prompt("Введите n: "));
arr = FillArrayRandom(arr);
PrintArray(arr);
arr = FillArray(arr);
System.Console.WriteLine("****************************************");
PrintArray(arr);