// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на
// нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] RandomArr()
{
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]}");
        if (i != mass.Length - 1)
        {
            Console.Write(", ");

        }
    }
    Console.WriteLine();
}

int GetSumOdd(int[] mass)
{
    int sum = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += mass[i];
        }
    }
    return sum;
}

int[] array = RandomArr();
PrintArray(array);
int result = GetSumOdd(array);
Console.WriteLine(result);

