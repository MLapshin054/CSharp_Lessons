// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"Пересечение в точке: ({x} ; {y})");


// Пример идеального решения

// const int COEFFICIENT = 0;
// const int CONSTANT = 1;
// const int X_COORD = 0;
// const int Y_COORD = 1;
// const int LINE1 = 1;
// const int LINE2 = 2;

// double[] lineData1 = InputLineData(LINE1);
// double[] lineData2 = InputLineData(LINE2);

// if (ValidateLines(lineData1, lineData2))
// {
//   double[] coord = FindCoords(lineData1, lineData2);
//   Console.Write($"Точка пересечения уравнений y={lineData1[COEFFICIENT]} * x + {lineData1[CONSTANT]} и y={lineData2[COEFFICIENT]} * x + {lineData2[CONSTANT]} ");
//   Console.WriteLine($" имеет координаты ({coord[X_COORD]}), ({coord[Y_COORD]})");
// }

// double Prompt(string message)
// {
//   Console.WriteLine(message);
//   string value = Console.ReadLine();
//   double result = Convert.ToDouble(value);
//   return result;
// }

// double[] InputLineData(int numberOfLine)
// {
//   double[] lineData = new double[2];
//   lineData[COEFFICIENT] = Prompt($"Ввдите коэффициент для {numberOfLine} прямой > ");
//   lineData[CONSTANT] = Prompt($"Ввдите константу для {numberOfLine} прямой > ");
//   return lineData;
// }

// double[] FindCoords(double lineData1, double lineData2)
// {
//   double[] coord = new double[2];
//   coord[X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
//   coord[Y_COORD] = lineData1[CONSTANT] * coord[X_COORD] + lineData1[CONSTANT];
//   return coord;
// }

// bool ValidateLines(double[] lineData1, double[] lineData2)
// {
//   if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
//   {
//     if (lineData1[CONSTANT] == lineData2[CONSTANT])
//     {
//       Console.WriteLine("Прямые совпадают");
//       return false;
//     }
//     else
//     {
//       Console.WriteLine("Прямые параллельны");
//       return false;
//     }
//   }
//   return true;
// }