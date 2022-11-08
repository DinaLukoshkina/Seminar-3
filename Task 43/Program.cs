// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

writeDistance(k1, k2, b1, b2);

void writeDistance(double k1, double k2, double b1, double b2)
{
    double x, y;

    x = (b1 - b2) / (k2 - k1);
    y = k1 * x + b1;

    Console.WriteLine("x: {0}, y: {1}", x, y);
}