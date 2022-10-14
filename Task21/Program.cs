// Задача 21 
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
// A (3,6,8); B (2,1,-7), -> 15.84 
// A (7,-5, 0); B (1,-1,9) -> 11.53 

Console.Clear();
Console.Write("Введите x точки A: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите y точки A: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите l точки A: ");
int l1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите x точки B: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите y точки B: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите l точки B: ");
int l2 = int.Parse(Console.ReadLine()!);
double calculateDistance(int x1, int y1, int x2, int y2, int l1, int l2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(l2 - l1, 2));
}
double distance = calculateDistance(x1, y1, x2, y2, l1, l2);
Console.WriteLine($" Расстояние между точками А и В в 3D пространстве = {distance:f2}");