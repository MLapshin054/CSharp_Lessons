// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

int Calculate(int inputNumber, int inputDegree)
{
  int result = 1;
  for (int i = 0; i < inputDegree; i++)
  {
    result = result * inputNumber;
  }
  return result;
}

Console.WriteLine(Calculate(number, degree));