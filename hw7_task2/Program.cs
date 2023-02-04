using System;
using static System.Console;

Clear();
WriteLine("Введите количество строк массива: ");
int row = Convert.ToInt32(ReadLine());
WriteLine("Введите количество стобцов массива: ");
int column = Convert.ToInt32(ReadLine());
int[,] Myarray = FillArrayRandom(row, column, 0, 30);
PrintArray(Myarray);

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

WriteLine("Введите номер строки элемента: ");
int userrow = Convert.ToInt32(ReadLine());
WriteLine("Введите номер столбца элемента: ");
int usercolumn = Convert.ToInt32(ReadLine());
if (userrow > row || usercolumn > column)
    WriteLine("Такого элемента нет!");
else
{
    WriteLine(Myarray[userrow - 1, usercolumn - 1]);
}
