using System;
using static System.Console;

Clear();
Write("Введите число: ");
int a=int.Parse(ReadLine());
int len=Lennumber(a);

int Lennumber(int a)
{
    int len=0;
    while(a>0)
    {
        a/=10;
        len++;
    }
    return len;
}
int Summnumber(int a, int len)
{
    int summ=0;
    for (int i=1; i<=len; i++)
    {
        summ += a%10;
        a/=10;
    }
    return summ;
}
int myresult=Summnumber(a, len);
Write($"Сумма цифр в числе: {myresult}");
