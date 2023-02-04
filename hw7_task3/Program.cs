using System;
using static System.Console;

Clear();
Random random = new Random();
int[,] Myarray = new int[random.Next(2, 5), random.Next(2, 5)];
for (int i = 0; i < Myarray.GetLength(0); i++)
{
    for (int k = 0; k < Myarray.GetLength(1); k++)
    {
        Myarray[i, k] = random.Next(1, 30);
        Console.Write(Myarray[i, k] + "  ");
    }
    WriteLine();
}
WriteLine();

float result = 0;
for (int k = 0; k < Myarray.GetLength(1); k++)
{
    float summ = 0;
    for (int i = 0; i < Myarray.GetLength(0); i++)
    {
        summ += Myarray[i, k];
        result = summ / Myarray.GetLength(0);
    }
    Write($"{Math.Round(result, 2)}  ");
}
