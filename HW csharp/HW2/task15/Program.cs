// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Введи цифру, которая обозначает день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
{
  Console.WriteLine("Да. Это выходной день");
}
else if (number < 1 || number > 7)
{
  Console.WriteLine("Это не день недели! Введите значение от 1 до 7");
}
else Console.WriteLine("Нет. Это будний день");