// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)



public class Program
{
    public static void Main()
    {

        //int[,] arr1 = { { 2, 4},
        //		   { 3, 2 } };
        //	int[,] arr2 = { { 3, 4 },
        //			   { 3, 3} };

        int[,,] arr = new int[,,] {
            {
                { 66, 25 }, { 34, 41 }
            },
            {
                { 27, 90 }, { 26, 55 }
            }
        };

        consoleWriteArray(arr);

    }

    public static void consoleWriteArray(int[,,] arr)
    {
        int arrSize = 2;
        for (int i = 0; i < arrSize; i++)
        {
            for (int j = 0; j < arrSize; j++)
            {
                for (int k = 0; k < arrSize; k++)
                {
                    Console.Write(arr[(i), (j), (k)] + "()");
                }
                Console.WriteLine();
            }
        }
    }

}

