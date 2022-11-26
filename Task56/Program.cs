// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

public class Program
{
    public static void Main()
    {
        int[,] arr = {
            { 4, 1, 0, 45 },
            { 3, 2, 1, 98},
            { 0, 1, 0, 33},
            { 0, 1, 15, 1},
        };

        int minSum = 0;
        int minSumIndex = 0;
        int currentSum = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            currentSum = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                currentSum += arr[i, j];
            }
            if (i == 0 || currentSum < minSum)
            {
                minSum = currentSum;
                minSumIndex = i;
            }
        }

        Console.WriteLine("Min: {0}", minSumIndex);
    }
}
