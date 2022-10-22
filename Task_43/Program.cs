// Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

void GetCoordinates(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        Console.WriteLine("Прямые не пересекаются");
    }
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = k2 * x + b2;
        x = Math.Round(x, 2);
        y = Math.Round(y, 2);
        Console.WriteLine($"Координаты пересечения прямых: {(x, y):f2}");
    }
}

Console.Write("Введите b1: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите k1: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите b2: ");
int c = int.Parse(Console.ReadLine()!);

Console.Write("Введите k2: ");
int d = int.Parse(Console.ReadLine()!);

GetCoordinates(a, b, c, d);