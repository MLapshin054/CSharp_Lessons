// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumOfNumber(int numb)
{
  int result = 0;
  while (numb > 0)
  {
    result = result + (numb % 10);
    numb /= 10;
  }
  return result;
}

System.Console.WriteLine(SumOfNumber(number));