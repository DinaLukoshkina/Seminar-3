//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.				
public class Program
{
    public static void Main()
    {
        int evenNumbersCount = 0;
        int arrLength = 10;

        int[] arr = fillArray(arrLength);

        for (int i = 0; i < arrLength; i++)
        {
            if (isEvenNumber(arr[i]))
            {
                evenNumbersCount++;
            }
        }

        writeArray(arr);
        Console.WriteLine("{0}", evenNumbersCount);
    }

    public static int[] fillArray(int arrLength)
    {
        int[] arr = new int[arrLength];

        Random rnd = new Random();
        for (int i = 0; i < arrLength; i++)
        {
            arr[i] = rnd.Next(99, 999);
        }

        return arr;
    }

    public static bool isEvenNumber(int number)
    {
        return ((number % 2) == 0);
    }

    public static void writeArray(int[] arr)
    {
        Console.WriteLine(
            '[' + String.Join(", ", arr) + ']'
        );
    }
}
