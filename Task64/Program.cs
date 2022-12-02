// Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Clear();
Console.WriteLine("Задайте значение N");
int n = int.Parse(Console.ReadLine()!);

string Numbers(int n)
{
    if (n < 1) return $"Не натуриальное число";
    if (n == 1) return $"{1}";
    else return $"{n}" + Numbers(n - 1);
}


Console.WriteLine($"N = {n} -> Все натуральные числа {Numbers(n)}");
