using System;
using static System.Console;

Clear();
WriteLine("Введите количество строк массива: ");
int row = Convert.ToInt32(ReadLine());
WriteLine("Введите количество стобцов массива: ");
int column = Convert.ToInt32(ReadLine());
int[,] array = FillArrayRandom(row, column, 0, 30);
WriteLine();
PrintArray(array);
WriteLine();
SortToLow(array);
PrintArray(array);

void SortToLow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int n = 0; n < array.GetLength(1) - 1; n++)
            {
                if (array[i, n] < array[i, n + 1])
                {
                    int temp = array[i, n + 1];
                    array[i, n + 1] = array[i, n];
                    array[i, n] = temp;
                }
            }
        }
    }
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
