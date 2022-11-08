// Задача 50. Напишите программу, которая на вход принимает число и возвращает индексы элемента в двумерном массиве или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите число: ");
int inputNumber = int.Parse(Console.ReadLine()!);

int [,] arr = fillArray(4, 5);

writeValueKeys(arr, inputNumber);

void writeValueKeys(int[,] arr, int value)
{
    int arrHeight = arr.GetLength(0);
    if (arrHeight < 0) {
        return;
    }

    int arrWidth = arr.GetLength(1);

    for (int i = 0; i < arrHeight; i++)
    {
        for (int j = 0; j < arrWidth; j++)
        {
            if (arr[i, j] == value) {
                Console.WriteLine("{0}, {1}\t", j, i);
            }
        }
    }
}



int[,] fillArray(int width, int height)
{
    int[,] arr = new int[height, width];
    Random rand = new Random();

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            arr[i, j] = rand.Next(-10, 10);
            Console.Write("{0}\t", arr[i, j]);
        }
        Console.WriteLine();
    }

    return arr;
}



