using System;
using static System.Console;

Clear();
int m = 3;
int n = 4;
double[,] numbers = new double[m, n];
FillArrayRandom(numbers);
PrintArray(numbers);

void FillArrayRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = Convert.ToDouble(new Random().Next(-500, 500)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Write($"{array[i, k]}  ");
        }
        WriteLine(" ");
    }
}
