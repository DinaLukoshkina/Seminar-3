//Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18


public class Program
{
    public static void Main()
    {

        writeDistance(5, 9, 2, 4);
    }

    public static void writeDistance(double k1, double k2, double b1, double b2)
    {
        double x, y;

        x = (b1 - b2) / (k2 - k1);
        y = k1 * x + b1;

        Console.WriteLine("x: {0}, y: {1}", x, y);
    }

}
