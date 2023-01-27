using System;

Console.Clear();
Console.Write("Введите число: ");
int a=int.Parse(Console.ReadLine());
int b=a % 2;
if (b == 0)
    Console.WriteLine($"{a} - четное число!");
else
    Console.WriteLine($"{a} - нечетное число!");
