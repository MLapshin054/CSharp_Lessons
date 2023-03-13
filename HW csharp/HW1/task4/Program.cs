//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int numb1, numb2, numb3;

System.Console.Write("Введите первое число: ");
numb1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
numb2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
numb3 = Convert.ToInt32(Console.ReadLine());

if(numb1 > numb2 && numb1 > numb3)
{
    System.Console.WriteLine($"Наибольшее число: {numb1}");
}
else if(numb2 > numb1 && numb2 > numb3)
{
    System.Console.WriteLine($"Наибольшее число: {numb2}");
}
else
{
    System.Console.WriteLine($"Наибольшее число: {numb3}");
}