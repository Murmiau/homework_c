using System;
using static System.Console;

Clear();
Write("Введите число: ");
int a=int.Parse(ReadLine());

if (a<100)
{
    WriteLine($"Третьей цифры нет!");
}
else
{
    while(a>999)
    {
        a=a/10;
    }
    a=a%10;
    WriteLine($"{a}");
}
