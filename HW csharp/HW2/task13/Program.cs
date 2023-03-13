// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int count = 0;

if (numberA > 100)
{
  for (int i = 100; i < numberA; i *= 10)
  {
    count = i;
  }
  int numberB = count / 100;
  Console.WriteLine((numberA / (numberB)) % 10);
}
else
{
  Console.WriteLine("Третьей цифры нет");
}