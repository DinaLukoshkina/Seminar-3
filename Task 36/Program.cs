//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

public class Program
{
    public static void Main()
    {
        int arrLength = 6;
        int oddNumbersSum = 0;

        int[] arr = fillArray(arrLength);

        for (int i = 0; i < arrLength; i++)
        {
            if (isOddNumber(i))
            {
                oddNumbersSum = oddNumbersSum + arr[i];
            }
        }

        writeArray(arr);
        Console.WriteLine("{0}", oddNumbersSum);
    }

    public static int[] fillArray(int arrLength)
    {
        int[] arr = new int[arrLength];

        Random rnd = new Random();
        for (int i = 0; i < arrLength; i++)
        {
            arr[i] = rnd.Next(-1000, 1000);
        }

        return arr;
    }

    public static bool isOddNumber(int number)
    {
        return ((number % 2) != 0);
    }

    public static void writeArray(int[] arr)
    {
        Console.WriteLine(
            '[' + String.Join(", ", arr) + ']'
        );
    }
}
