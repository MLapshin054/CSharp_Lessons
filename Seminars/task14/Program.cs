// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

System.Console.WriteLine("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());

if ((numb % 7 == 0) && (numb % 23 == 0))
{
  Console.WriteLine("Да");
}
else
{
  Console.WriteLine("Нет");
}