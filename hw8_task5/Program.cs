using System;
using static System.Console;

Console.Clear();
WriteLine("Введите первую цифру массива: ");
int numb = Convert.ToInt32(ReadLine());
int line = 4;
int[,] SquareMatrix = new int[line, line];
int i = 0;
int k = 0;

while (numb <= SquareMatrix.GetLength(0) * SquareMatrix.GetLength(1))
{
    SquareMatrix[i, k] = numb;
    numb++;
    if (i <= k + 1 && i + k < SquareMatrix.GetLength(1) - 1)
        k++;
    else if (i < k && i + k >= SquareMatrix.GetLength(0) - 1)
        i++;
    else if (i >= k && i + k > SquareMatrix.GetLength(1) - 1)
        k--;
    else
        i--;
}
WriteLine();
WriteArray(SquareMatrix);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write($"{array[i, k]} ");
        }
        Console.WriteLine();
    }
}
