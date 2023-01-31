using System;
using static System.Console;

Clear();
int[] array=GetArray(10,100,999);
WriteLine(String.Join(",",array));
int summ=0;
foreach(int item in array)
{
    if (item%2==0)
    {
        summ += 1;
    }
}
WriteLine($"Количество четных элементов в массиве: {summ}");
int[] GetArray(int size, int min, int max)
{
    int[] result=new int[size];
    for(int i=0; i<size; i++)
    {
        result[i]=new Random().Next(min, max+1);
    }
    return result;
}
