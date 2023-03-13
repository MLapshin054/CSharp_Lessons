// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

System.Console.WriteLine("Введите первое число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

int result = numb2 % numb1;

if (result == 0)
{
  Console.WriteLine("Кратно");
}
else
{
  Console.WriteLine($"Не кратно, остаток {result}");
}