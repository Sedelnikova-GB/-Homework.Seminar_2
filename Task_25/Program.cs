// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную 
// степень B. Реализовать функцию возведения в степень самостоятельно!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetMulty(int A, int B)
{
    int res = 1;
    for (int i = 0; i < B; i++)
    {
        res = res * A;
    }
    return res;
}

Console.Clear();
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число В: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetMulty(a, b));
