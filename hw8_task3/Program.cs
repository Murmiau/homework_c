using System;
using static System.Console;

Clear();
WriteLine("Введите количество строк 1-й матрицы: ");
int rowA = Convert.ToInt32(ReadLine());
WriteLine("Введите количество стобцов 1-й матрицы: ");
int columnA = Convert.ToInt32(ReadLine());
WriteLine("Введите количество строк 1-й матрицы: ");
int rowB = Convert.ToInt32(ReadLine());
WriteLine("Введите количество стобцов 1-й матрицы: ");
int columnB = Convert.ToInt32(ReadLine());

int[,] FirstMatrix = FillMatrixRandom(rowA, columnA, 0, 10);
int[,] SecondMatrix = FillMatrixRandom(rowB, columnB, 0, 10);
int[,] ResultMatrix = new int[rowA, columnB];

WriteLine();
PrintMatrix(FirstMatrix);
WriteLine();
PrintMatrix(SecondMatrix);
WriteLine();
MultipliedMatrix(FirstMatrix, SecondMatrix, ResultMatrix);

void MultipliedMatrix(int[,] FirstMartrix, int[,] SecondMartrix, int[,] ResultMatrix)
{
    if (rowA != columnB)
    {
        WriteLine("Умножение невозможно!");
        return;
    }
    else
        for (int i = 0; i < ResultMatrix.GetLength(0); i++)
        {
            for (int k = 0; k < ResultMatrix.GetLength(1); k++)
            {
                int summ = 0;
                for (int n = 0; n < FirstMartrix.GetLength(1); n++)
                {
                    summ += FirstMartrix[i, n] * SecondMartrix[n, k];
                }
                ResultMatrix[i, k] = summ;
            }
        }
    PrintMatrix(ResultMatrix);
}

int[,] FillMatrixRandom(int row, int column, int min, int max)
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

void PrintMatrix(int[,] array)
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
