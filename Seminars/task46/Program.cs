// Задача 46. Задайте двумерный массив размером m*n, заполненный случайными числами.

Console.Clear();
void PrintArray(double[,] matr)
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

void FillArray(double[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = Math.Round((new Random().NextDouble()) * 5, 1);
    }
  }
}

double[,] matrix = new double[3, 4];
FillArray(matrix);
PrintArray(matrix);
