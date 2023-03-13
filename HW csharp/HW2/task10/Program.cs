// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
{
  Console.WriteLine("Это не трехзначное число. Попробуйте еще раз!");
}
else
{
  Console.WriteLine(number / 10 % 10);
}