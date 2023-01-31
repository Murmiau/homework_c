using System;
using static System.Console;

Clear();
int[] array=GetArray(10, -50, 50);
WriteLine(String.Join(",",array));
int summ=0;
int index=0;
foreach(int item in array)
{
    if (index%2==0)
    {
        summ +=0;
        index++;
    }
    else
    {
        summ +=item;
        index++;
    }
}
WriteLine($"Сумма элементов, стоящих на нечётных позициях: {summ}");
int[] GetArray(int size, int min, int max)
{
    int[] result=new int[size];
    for(int i=0; i<size; i++)
    {
        result[i]=new Random().Next(min, max+1);
    }
    return result;
}
