using System;

Console.Clear();
Console.Write("Введите первое число: ");
int a=int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b=int.Parse(Console.ReadLine());
if (a > b)
    Console.WriteLine($"max = {a}, min = {b}");
else if (b > a)
    Console.WriteLine($"max = {b}, min = {a}");
else
    Console.WriteLine("Числа равны!");
