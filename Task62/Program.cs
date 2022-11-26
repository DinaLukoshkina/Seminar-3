// Напишите программу, которая заполнит спирально массив 4 на 4. 
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07


public class Program
{
    public static void Main()
    {

        int m = 4;
        int n = 4;

        int s = 1;

        int[,] arr = new int[m, n];

        for (int y = 0; y < n; y++)
        {
            arr[0, y] = s;
            s++;
        }
        for (int x = 1; x < m; x++)
        {
            arr[x, n - 1] = s;
            s++;
        }
        for (int y = n - 2; y >= 0; y--)
        {
            arr[m - 1, y] = s;
            s++;
        }
        for (int x = m - 2; x > 0; x--)
        {
            arr[x, 0] = s;
            s++;
        }

        int c = 1;
        int d = 1;

        while (s < m * n)
        {
            while (arr[c, d + 1] == 0)
            {
                arr[c, d] = s;
                s++;
                d++;
            }

            while (arr[c + 1, d] == 0)
            {
                arr[c, d] = s;
                s++;
                c++;
            }

            while (arr[c, d - 1] == 0)
            {
                arr[c, d] = s;
                s++;
                d--;
            }

            while (arr[c - 1, d] == 0)
            {
                arr[c, d] = s;
                s++;
                c--;
            }
        }

        for (int x = 0; x < m; x++)
        {
            for (int y = 0; y < n; y++)
            {
                if (arr[x, y] == 0)
                {
                    arr[x, y] = s;
                }
            }
        }

        for (int x = 0; x < m; x++)
        {
            for (int y = 0; y < n; y++)
            {
                if (arr[x, y] < 10)
                {
                    Console.Write("0" + arr[x, y] + " ");
                }
                else
                {
                    Console.Write(arr[x, y] + " ");
                }
            }
            Console.WriteLine();
        }

    }

}
