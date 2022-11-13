// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetArray(int m, int n)
{
    int[,] inArray = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            inArray[i, j] = new Random().Next(1, 5);
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

int[,] MultiplyMatrix(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    if (firstArray.GetLength(0) != secondArray.GetLength(1))
    {
        Console.WriteLine("Эти матрицы нельзя перемножить");
        return new int[0, 0];
    }
    for (int row = 0; row < resultArray.GetLength(0); row++)
    {
        for (int column = 0; column < resultArray.GetLength(1); column++)
        {
            int sum = 0;
            for (int i = 0; i < firstArray.GetLength(1); i++)
            {
                sum += firstArray[row, i] * secondArray[i, column];
            }
            resultArray[row, column] = sum;
        }
    }
    Console.WriteLine("результат:");
    return resultArray;
}

Console.Clear();
Console.Write("Введите количество строк в первом массиве: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в первом массиве: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns);
Console.Write("Введите количество строк во втором массиве: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов во втором массиве: ");
int columns2 = int.Parse(Console.ReadLine()!);
int[,] secondArray = GetArray(rows2, columns2);

PrintArray(array);
Console.WriteLine();
PrintArray(array);

Console.WriteLine();
PrintArray(MultiplyMatrix(array, secondArray));
