// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRec(int a, int b)
{
    if (a <= b) return b + SumRec(a, b - 1);
    else return 0;
}

Console.WriteLine("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{SumRec(m, n)}");