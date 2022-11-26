//Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

public class Program
{
    public static void Main()
    {
        int[,] arr = {
            { 4, 1, 0, 45 },
            { 3, 2, 1, 98},
            { 0, 1, 16, 33},
            { 0, 1, 15, 19},
        };

        int[] currentArr = new int[arr.GetLength(0)];

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                currentArr[j] = arr[i, j];
            }

            Array.Sort(currentArr);
            Array.Reverse(currentArr);

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = currentArr[j];
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

