// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введи координаты Ax: ");
double Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи координаты Ay: ");
double Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи координаты Az: ");
double Az = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи координаты Bx: ");
double Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи координаты By: ");
double By = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи координаты Bz: ");
double Bz = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2)), 2);
Console.WriteLine(distance);