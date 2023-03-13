// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
double[] ourNumb = new double[sizeArray];
FillArrayRandomNumbers(ourNumb);
Console.WriteLine("Наш массив: ");
PrintArray(ourNumb);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < ourNumb.Length; i++)
{
  if (ourNumb[i] > max)
  {
    max = ourNumb[i];
  }
  if (ourNumb[i] < min)
  {
    min = ourNumb[i];
  }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] ourNumb)
{
  for (int j = 0; j < ourNumb.Length; j++)
  {
    ourNumb[j] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
  }
}
void PrintArray(double[] ourNumb)
{
  Console.Write("[ ");
  for (int j = 0; j < ourNumb.Length; j++)
  {
    Console.Write(ourNumb[j] + " ");
  }
  Console.Write("]");
  Console.WriteLine();
}