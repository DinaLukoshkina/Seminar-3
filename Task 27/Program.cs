// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
int SumNamber(int n)
{
    int result = 0;
    while (n > 0)
    {
        result += n % 10;
        n = n / 10;
    }
    return result;
}
 int result = SumNamber(n);
Console.WriteLine($"Сумма цифр в числе {n} = {result}");