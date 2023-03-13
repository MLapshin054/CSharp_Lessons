﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите произвольное количество чисел через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
  if (arr[i] > 0)
  {
    count++;
  }
}

Console.WriteLine($"Кол-во элементов > 0: {count}");

// Пример идеального решения

// int Prompt(string message)
// {
//   System.Console.Write(message);
//   string value = Console.ReadLine();
//   int result = Convert.ToInt32(value);
//   return result;
// }

// int[] InputArray(int length)
// {
//   int[] array = new int[length];
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = Prompt($"Введите {i + 1}-й элемент ");
//   }
//   return array;
// }

// void PrintArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     Console.WriteLine($"a[{i}]={array[i]}");
//   }
// }

// int CountPositiveNumbers(int[] array)
// {
//   int count = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] > 0)
//     {
//       count++;
//     }
//   }
//   return count;
// }

// int length = Prompt("Введите количество элементов > ");
// int[] array;
// array = InputArray(length);
// PrintArray(array);
// Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");