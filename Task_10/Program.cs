// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int x = int.Parse(Console.ReadLine()!);
int y = x / 10;

Console.WriteLine($"{y % 10}");