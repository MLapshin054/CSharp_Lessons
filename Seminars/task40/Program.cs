// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

  if (a < b + c && b < a + c && c < a + b)
  {
    Console.WriteLine("Треугольник может существовать! ");
  }
  else
  {
    Console.WriteLine("Треугольник не может существовать.. ");
  }