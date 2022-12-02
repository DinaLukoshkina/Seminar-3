﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Задайте значение M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте значение N");
int n = int.Parse(Console.ReadLine()!);

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    return AkkermanFunction(m, n);
}

Console.WriteLine($"M = {m}; N = {n} -> = A ({m}, {n}) = {AkkermanFunction (m,n)}");
