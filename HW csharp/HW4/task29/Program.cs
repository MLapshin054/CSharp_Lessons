﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Если следовать заданию в задаче, то так:
int[] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
{
  numbers[i] = new Random().Next(0, 20);
  Console.Write(" " + Array(i) + " ");
}
Console.Write("]");

int Array(int a)
{
  return numbers[a];
}

// Если подводить решение, как указано в примерах: 
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// то я пока думаю над решением :)