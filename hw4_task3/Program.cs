using System;
using static System.Console;

Clear();
Write($"[{String.Join(",",MyArray(8))}]");

int[] MyArray(int size)
{
    int[] result=new int[size];
    for(int i=0;i<size;i++)
    {
        result[i]=new Random().Next(0,101);
    }
    return result;
}
