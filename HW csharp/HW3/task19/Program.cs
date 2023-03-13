// // Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int inputNum = Convert.ToInt32(Console.ReadLine());
int palindrom = 0, numb = inputNum;

while (inputNum > 0)
{
  palindrom = palindrom * 10 + inputNum % 10; inputNum /= 10;
}

if (numb == palindrom)
{
  System.Console.WriteLine($"{numb} -> да");
}
else
{
  System.Console.WriteLine($"{numb} -> нет");
}