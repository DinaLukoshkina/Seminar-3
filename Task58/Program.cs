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

        //int[,] arr1 = { { 2, 4},
        //       { 3, 2 } };
        //  int[,] arr2 = { { 3, 4 },
        //         { 3, 3} };

        int[,] arr1 = { { 2, 0, -1},
             { 0, -2, 2 } };
        int[,] arr2 = { { 4, 1, 0 },
             { 3, 2, 1},
             { 0, 1, 0},
            };

        multiplyArrays(arr1, arr2);

    }

    public static void multiplyArrays(int[,] arr1, int[,] arr2)
    {

        int[,] result = new int[arr1.GetLength(0), arr2.GetLength(0)];

        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    result[i, j] += arr1[i, k] * arr2[k, j];
                }
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

}