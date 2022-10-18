// Напишите цикл, который принимает на вход два число A и В 
// и возводит число А в натуральную степень В
Console.Clear();
Console.Write("Введите А: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите B: ");
int b = int.Parse(Console.ReadLine()!);
void NC(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}
NC(a,b);
