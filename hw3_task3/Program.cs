using System;
using static System.Console;

Clear();
Write("Введите число: ");
int N=int.Parse(ReadLine());

for(int i=1;i<=N;i++)
{
    Write($"{i*i*i} ");
}
