//Задача 19 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// 14212 -> нет 
// 12821 -> да 
// 23432 -> да 
Console.Clear();
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine()!);
if (getDigit(number, 1) == getDigit(number, 5) &&
getDigit(number, 2) == getDigit(number, 4))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

int getDigit(int x, int digitNumber)
{
    int digitCount = (int)Math.Log10(x) + 1;
    int pow = (int)Math.Pow(10, digitCount - digitNumber);
    return (x / pow) % 10;
}