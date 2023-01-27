using System;

Console.Clear();
Console.Write("Введите первое число: ");
int a=int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b=int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c=int.Parse(Console.ReadLine());
if (a >= b)
    if (a > b)
        if (a > c)
            Console.WriteLine($"max = {a}");
        else
            Console.WriteLine($"max = {c}");
    else
        if (a == c)
            Console.WriteLine($"Все числа равны!");
        else if (a > c)
            Console.WriteLine($"max = {a}");
        else
            Console.WriteLine($"max = {c}");
else if (b >= c)
    if (b > c)
        Console.WriteLine($"max = {b}");
    else
        if (a == c)
            Console.WriteLine($"Все числа равны!");
        else
            Console.WriteLine($"max = {b}");
else
    Console.WriteLine($"max = {c}");
          