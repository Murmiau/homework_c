using System;
using static System.Console;

Clear();
WriteLine("Введите значение M (начало промежутка): ");
int M = int.Parse(ReadLine());
WriteLine("Введите значение N (конец промежутка): ");
int N = int.Parse(ReadLine());
WriteLine(PrintNumber(M, N));

string PrintNumber(int M, int N)
{
    if (M == N) return M.ToString();
    return (M + " " + PrintNumber(M + 1, N));
}
