//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int max = 0;
int min = 0;

System.Console.WriteLine("Введите первое число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
if(numb1 > numb2)
{
  max = numb1;
  min = numb2;
}
else
{
  max = numb2;
  min = numb1;
}
Console.WriteLine("Большее = " + max + " и " + "меньшее = " + min);