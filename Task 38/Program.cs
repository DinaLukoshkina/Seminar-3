// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


public class Program
{
    public static void Main()
    {
        int arrLength = 6;
        int minValueIndex = 0;
        int maxValueIndex = 0;

        int[] arr = fillArray(arrLength);

        for (int i = 1; i < arrLength; i++)
        {
            if (arr[i] < arr[minValueIndex])
            {
                minValueIndex = i;
            }
            if (arr[i] > arr[maxValueIndex])
            {
                maxValueIndex = i;
            }
        }

        writeArray(arr);
        Console.WriteLine("{0}", arr[maxValueIndex] - arr[minValueIndex]);
    }

    public static int[] fillArray(int arrLength)
    {
        int[] arr = new int[arrLength];

        Random rnd = new Random();
        for (int i = 0; i < arrLength; i++)
        {
            arr[i] = rnd.Next(0, 100);
        }

        return arr;
    }

    public static void writeArray(int[] arr)
    {
        Console.WriteLine(
            '[' + String.Join(", ", arr) + ']'
        );
    }
}