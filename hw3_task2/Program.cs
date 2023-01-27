using System;
using static System.Console;

Clear();
Write("Введите x1: ");
int x1=int.Parse(ReadLine());
Write("Введите y1: ");
int y1=int.Parse(ReadLine());
Write("Введите z1: ");
int z1=int.Parse(ReadLine());
Write("Введите x2: ");
int x2=int.Parse(ReadLine());
Write("Введите y2: ");
int y2=int.Parse(ReadLine());
Write("Введите z2: ");
int z2=int.Parse(ReadLine());

double S=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
{
    WriteLine($"{S:f2} - расстояние между двумя точками в 3D пространстве");
}
