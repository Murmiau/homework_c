using System;
using static System.Console;

Clear();
Write("Введите трехзначное число: ");
int a=int.Parse(ReadLine());

if ((a>99)&&(a<1000))
{
    int result=a / 10 % 10;
    WriteLine($"{a}->{result}");
}
else
{
    Write($"Вы ввели не трехзначное число!");
}
