//Напишите программу, которая задаёт массив из N элементов
// и выводит их на экран.
//5 -> [1, 2, 5, 7, 19]
//3 -> [6, 1, 33]
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void InputArray(int[] array)
{
    for(int i = 0; i< array.Length; i++)
        array[i] = new Random().Next(0, 100);
}

Console.Clear();
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");