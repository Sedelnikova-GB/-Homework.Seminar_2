// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int AckermanFunction(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else if (a > 0 && b == 0)
    {
        return AckermanFunction(a - 1, 1);
    }
    else
    {
        return AckermanFunction(a - 1, AckermanFunction(a, b - 1));
    }
}
Console.WriteLine("Введите неотрицательное число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе неотрицательное число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {AckermanFunction(m, n)}");