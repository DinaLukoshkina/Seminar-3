//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
public class Program
{
    public static void Main()
    {
        Console.Write("Введите число 1: ");
        int n1 = int.Parse(Console.ReadLine()!);
        Console.Write("Введите число 2: ");
        int n2 = int.Parse(Console.ReadLine()!);
        Console.Write("Введите число 3: ");
        int n3 = int.Parse(Console.ReadLine()!);
        Console.Write("Введите число 4: ");
        int n4 = int.Parse(Console.ReadLine()!);
        Console.Write("Введите число 5: ");
        int n5 = int.Parse(Console.ReadLine()!);
        Console.Write("Введите число 6: ");
        int n6 = int.Parse(Console.ReadLine()!);
        Console.Write("Введите число 7: ");
        int n7 = int.Parse(Console.ReadLine()!);
        Console.Write("Введите число 8: ");
        int n8 = int.Parse(Console.ReadLine()!);
        int[] arr = new int[] { n1, n2, n3, n4, n5, n6, n7, n8 };
        Console.WriteLine('[' + String.Join(",", arr) + ']'
        );
    }
}
