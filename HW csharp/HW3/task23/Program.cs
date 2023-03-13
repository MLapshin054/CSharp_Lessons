﻿//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int counter = 0;
  int length = cube.Length;
  while (counter < length)
  {
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 1;
  while (index < count)
  {
    Console.Write(coll[index] + " ");
    index++;
  }
}

int[] arry = new int[cube + 1];
Cube(arry);
PrintArry(arry);

// Или "дешево и сердито" :)

// Console.Write("Введи число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= n; i++)
// {
//   System.Console.WriteLine(i * i * i);
// }