using System;
using static System.Console;

Clear();
WriteLine("Введите значение M (начало промежутка): ");
int M = Convert.ToInt32(ReadLine());
WriteLine("Введите значение N (конец промежутка): ");
int N = Convert.ToInt32(ReadLine());
WriteLine(PrintNumber(M, N));
Summ(M, N, 0);

string PrintNumber(int M, int N)
{
    if (M == N) return M.ToString();
    return (M + " " + PrintNumber(M + 1, N));
}

void Summ(int M, int N, int summ)
{
    if (M > N)
    {
        WriteLine($"Сумма чисел: {summ}");
        return;
    }
    summ = summ + (M++);
    Summ(M, N, summ);
}
