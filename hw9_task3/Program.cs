using System;
using static System.Console;

Clear();
WriteLine("Введите первое число (не отрицательное): ");
int M = int.Parse(ReadLine());
WriteLine("Введите второе число (не отрицательное): ");
int N = int.Parse(ReadLine());
WriteLine($"Функция Аккермана для заданных чисел: A({M}, {N}) = {AckermannF(M, N)}");

int AckermannF(int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return AckermannF(M - 1, 1);
    if (M > 0 && N > 0) return AckermannF(M - 1, AckermannF(M, N - 1));
    return AckermannF(M, N);
}
