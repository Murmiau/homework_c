using System;
using static System.Console;

Clear();
Write("Введите число b1: ");
double b1 = Convert.ToInt32(ReadLine());
Write("Введите число k1: ");
double k1 = Convert.ToInt32(ReadLine());
Write("Введите число b2: ");
double b2 = Convert.ToInt32(ReadLine());
Write("Введите число k2: ");
double k2 = Convert.ToInt32(ReadLine());
double x = (b2-b1)/(k1-k2);
double y = k1*(b2-b1)/(k1-k2)+b1;
Console.WriteLine($"Точка пересечения прямых: ({x};{y})");
