using System;
using static System.Console;

Clear();
int[] array=GetArray(10, 0, 100);
WriteLine(String.Join(",",array));
int i=0;
int max=0;
int min=100;
foreach(int item in array)
{
    if (max<item)
    {
        max=item;
        if (max<min)
        {
            min=max;
            i++;
        }
        else
        {
            i++;
        }
    }   
    else if (min>item)
    {
        min=item;
        i++;
    }
    else
    {
        i++;
    }
}
int myresult=max-min;
WriteLine($"Разница между максимальным и минимальным элементом: {myresult}");
int[] GetArray(int size, int min, int max)
{
    int[] result=new int[size];
    for(int i=0; i<size; i++)
    {
        result[i]=new Random().Next(min, max+1);
    }
    return result;
}
