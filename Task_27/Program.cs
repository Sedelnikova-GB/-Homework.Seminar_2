// Задача 27: Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int n)
{
    int sum = 0;
    while (n != 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
int result = Sum(x);
Console.WriteLine(result);