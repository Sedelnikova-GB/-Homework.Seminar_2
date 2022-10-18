// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов
// массива.
// [3 7 22 2 78] -> 76

double[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] res = new double[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = double.Parse(nums[i]);
    }
    return res;
}

double FindMax(double[] array)
{
    int i = 1;
    double max = array[0];
    while (i < array.Length)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        i++;
    }
    return max;
}

double FindMin(double[] array)
{
    int i = 1;
    double min = array[0];
    while (i < array.Length)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        i++;
    }
    return min;
}

Console.Clear();
Console.Write("Введите массив чисел: ");
string str = Console.ReadLine()!;
double[] array = GetArrayFromString(str);
double min = FindMin(array);
double max = FindMax(array);
Console.WriteLine(max - min);

