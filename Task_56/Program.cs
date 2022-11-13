// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[,] GetArray(int m, int n)
{
    int[,] inArray = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            inArray[i, j] = new Random().Next(0, 10);
        }
    }
    return inArray;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void GetSumElements(int[,] array)
{
    int temp;
    int minSum = 0;
    int result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSum += array[0, j];
    }
    for (int row = 0; row < array.GetLength(0); row++)
    {
        temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[row, j];
        }
        if (temp < minSum)
        {
            minSum = temp;
            result = row;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {result + 1}");
}
Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns);
PrintArray(array);
Console.WriteLine();
GetSumElements(array);

