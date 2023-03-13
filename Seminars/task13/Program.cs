// Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

System.Console.WriteLine("Введите первое число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

if ((numb2 == Math.Pow(numb1, 2)) || (numb1 == Math.Pow(numb2, 2)))
{
  Console.WriteLine("Да");
}
else
{
  Console.WriteLine("Нет");
}