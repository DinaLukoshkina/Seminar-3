// Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.Clear();
Console.Write("Введите ширину массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите длину массива: ");
int n  = int.Parse(Console.ReadLine()!);

fillArray(m, n);

int[,] fillArray(int width, int height)
{
    int[,] arr = new int[height, width];
    Random rand = new Random();

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            arr[i, j] = rand.Next(-10, 10);
        }
    }

    return arr;
}
