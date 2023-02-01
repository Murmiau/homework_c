using System;
using static System.Console;

Clear();
Write("Введите числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
foreach(int item in array)
{
    if (item>0)
    {
        count +=1;
    }
    else
    {
        count +=0;
    }
}
 WriteLine($"Количество элементов > 0: {count}");
