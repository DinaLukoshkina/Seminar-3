// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

public class Program
{
    public static void Main()
    {
        calculateAverage();
    }

    public static float[] calculateAverage()
    {
        int arrSize = 4;
        int[,] arr = fillArray();
        float[] averageArr = new float[arrSize];

        for (int i = 0; i < arrSize; i++)
        {
            for (int j = 0; j < arrSize; j++)
            {
                if (i == 0)
                {
                    averageArr[j] = 0;
                }

                averageArr[j] = averageArr[j] + arr[i, j];

                if (i == (arrSize - 1))
                {
                    averageArr[j] = averageArr[j] / arrSize;
                    Console.WriteLine("{0} ", averageArr[j]);
                }
            }
        }
        return averageArr;
    }
    public static int[,] fillArray()
    {
        //можно использовать функцию fillArray из предыдущих задач, чтобы заполнить массив случайными числами
        int[,] arr = new int[4, 4]
        {
            {1,2,4,6},
            {1,2,2,6},
            {5,2,4,8},
            {1,5,1,6},
        };

        return arr;
    }
}