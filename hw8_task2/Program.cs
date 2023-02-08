using System;
using static System.Console;

Clear();
WriteLine("Введите количество строк массива: ");
int row = Convert.ToInt32(ReadLine());
WriteLine("Введите количество стобцов массива: ");
int column = Convert.ToInt32(ReadLine());
int[,] array = FillArrayRandom(row, column, 0, 10);
WriteLine();
PrintArray(array);
WriteLine();
MinSumm(array);

void MinSumm(int[,] array)
{
    int summ = 0;
    int minimalsumm = 0;
    int line = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minimalsumm += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
            summ += array[i, k];
        if (summ < minimalsumm)
        {
            minimalsumm = summ;
            line = i;
        }
        summ = 0;
    }
    WriteLine($"Минимальная сумма {minimalsumm} в {line + 1} строке");
}

int[,] FillArrayRandom(int row, int column, int min, int max)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int k = 0; k < result.GetLength(1); k++)
        {
            result[i, k] = Convert.ToInt32(new Random().Next(min, max + 1));
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Write($"{array[i, k]}  ");
        }
        WriteLine();
    }
}
