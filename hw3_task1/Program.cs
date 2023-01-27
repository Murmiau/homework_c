using System;
using static System.Console;

Clear();
Write("Введите число: ");
int a=int.Parse(ReadLine());

int b = a / 10000; 
int c = a % 10;
int d = a/1000 % 10;
int e = a % 100 / 10;
if (b==c && d==e)
{
    WriteLine($"{a} - палиндром");
}
else
{
    Write($"{a} - не палиндром");
}
