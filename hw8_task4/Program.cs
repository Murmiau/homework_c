using System;
using static System.Console;

Clear();
WriteLine("Массив размером 2x2x2: ");
WriteLine();
int x = 2;
int y = 2;
int z = 2;

int[,,] Myarray = new int[x, y, z];
CreateArray(Myarray);
PrintArray(Myarray);

void PrintArray(int[,,] Myarray)
{
    for (int i = 0; i < Myarray.GetLength(0); i++)
    {
        for (int k = 0; k < Myarray.GetLength(1); k++)
        {
            for (int n = 0; n < Myarray.GetLength(2); n++)
            {
                Write($"{Myarray[i, k, n]} ({i},{k},{n}); ");
            }
            WriteLine();
        }
    }
    WriteLine();
}

void CreateArray(int[,,] Myarray)
{
    int[] digit = new int[Myarray.GetLength(0) * Myarray.GetLength(1) * Myarray.GetLength(2)];
    int number;
    for (int i = 0; i < digit.GetLength(0); i++)
    {
        digit[i] = new Random().Next(10, 100);
        number = digit[i];
        if (i >= 1)
        {
            for (int k = 0; k < i; k++)
            {
                while (digit[i] == digit[k])
                {
                    digit[i] = new Random().Next(10, 100);
                    k = 0;
                    number = digit[i];
                }
                number = digit[i];
            }
        }
    }

    int count = 0;
    for (int x = 0; x < Myarray.GetLength(0); x++)
    {
        for (int y = 0; y < Myarray.GetLength(1); y++)
        {
            for (int z = 0; z < Myarray.GetLength(2); z++)
            {
                Myarray[x, y, z] = digit[count];
                count++;
            }
        }
    }
}
