/// Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет,
// является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите номер дня недели");
int x = int.Parse(Console.ReadLine()!);

if (x == 6 || x == 7)
{
	Console.WriteLine("Выходной день");
}
else
{
	Console.WriteLine("Будничный день");
}	