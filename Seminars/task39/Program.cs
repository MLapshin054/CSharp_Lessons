// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateArr(int number)
{
  Console.Write("Левая граница рандомных чисел: ");
  int start = Convert.ToInt32(Console.ReadLine());
  Console.Write("Правая граница рандомных чисел: ");
  int stop = Convert.ToInt32(Console.ReadLine());

  int[] Arr = new int[number];
  for (int i = 0; i < Arr.Length; i++)
  {
    Arr[i] = new Random().Next(start, stop + 1);
  }
  return Arr;
}

int[] ReversArr(int[] Array)
{
  for (int i = 0, j = Array.Length - 1; i < Array.Length / 2; i++, j--)
  {
    int tmp = Array[j];
    Array[j] = Array[i];
    Array[i] = tmp;
  }
  return Array;
}

int[] res = CreateArr(5);
Console.WriteLine(String.Join(" ", res));
Console.WriteLine(String.Join(" ", ReversArr(res)));