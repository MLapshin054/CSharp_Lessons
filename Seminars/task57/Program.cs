// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

Console.Clear();
int Prompt(string massege)
{
  System.Console.Write(massege);
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
      coll[i, j] = new Random().Next(0, 10);
    }
  }
  return coll;
}

int[] FindNumber(int[,] arr)
{
  string result = string.Empty;
  int[] res = new int[arr.GetLength(0) * arr.GetLength(1)];
  int k = 0;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      res[k] = arr[i, j];
      k++;
    }
  }
  return res;
}

void CountNum(int[] arr)
{
  int[] numbers = new int[10];
  for (int i = 0; i < arr.Length; i++)
  {
    numbers[arr[i]]++;
  }
  for (int i = 0; i < numbers.Length; i++)
  {
    Console.WriteLine($"цифр {i} - {numbers[i]}");
  }
}

void Main()
{
  int[,] arr = CreateArray(Prompt("Введи количество строк: "), Prompt("Введи количество столбцов: "));
  arr = FillArrayRandom(arr);
  PrintArr(arr);
  Console.WriteLine();
  CountNum(FindNumber(arr));
}

Main();