// Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


Console.Clear();
Console.WriteLine("Задайте значение M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте значение N");
int n = int.Parse(Console.ReadLine()!);

int Sum(int m, int n)
{
    if (m == n) return n;
    if (m > n) return m + Sum(m - 1, n);
    else return m + Sum(m + 1, n);
}

Console.WriteLine($"M = {m}; N = {n} - Сумма натуральных чисел = {Sum(m, n)}");