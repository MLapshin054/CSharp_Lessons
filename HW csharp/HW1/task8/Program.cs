//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

int myNumber;

System.Console.WriteLine("Введите число: ");
myNumber = Convert.ToInt32(Console.ReadLine());

int iter = 2;

while (iter <= myNumber)
{
    System.Console.Write(iter + ", ");
    iter += 2;
}