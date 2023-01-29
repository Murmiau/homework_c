using System;
using static System.Console;

Clear();
Write("Введите число a: ");
int a=int.Parse(ReadLine());
Write("Введите число b: ");
int b=int.Parse(ReadLine());

int Pownumber(int a, int b)
{
    int result=a;
    for (int i=1; i<b; i++)
    {
        result *= a;
    }
    return result;
}
int myresult=Pownumber(a,b);
Write($"{myresult}");
