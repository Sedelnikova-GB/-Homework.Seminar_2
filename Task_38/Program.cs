// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов
// массива.
// [3 7 22 2 78] -> 76

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int FindMax(int[] array)
{
    int i = 1;
    int max = array[0];
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

int FindMin(int[] array)
{
    int i = 1;
    int min = array[0];
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
Console.Write("Введите масссив чисел: ");
string str = Console.ReadLine()!;
int[] array = GetArrayFromString(str);
int min = FindMin(array);
int max = FindMax(array);
Console.WriteLine(max - min);

