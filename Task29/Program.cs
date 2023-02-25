// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите максимальное значение массива, состоящего из 8 элементов:");
int numberMax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива, состоящего из 8 элементов:");
int numberMin = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Массив из 8 случайных элементов от {numberMin} до {numberMax} выглядит следующим образом:");
int[] newArray = NewArray(8, numberMin, numberMax);

PrintArray(newArray);
Console.Write(" -> ["); 
PrintArray(newArray);
Console.Write("]");

int[] NewArray(int num, int numMin, int numMax)
{
    Random random = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = random.Next(numMin, numMax+1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    int i = 0;
    while (i < array.Length-1)
    {
        Console.Write($"{array[i]}, ");
        i++;
    }
    if (i == array.Length-1) Console.Write($"{array[i]}");
}  