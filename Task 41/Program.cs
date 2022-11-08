// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите элементы: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int positiveNumbersCount = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        positiveNumbersCount++;
    }
}
 
Console.WriteLine($"Кол-во элементов больше 0 = {positiveNumbersCount}");