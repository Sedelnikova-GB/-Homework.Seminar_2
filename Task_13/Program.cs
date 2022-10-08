// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine()!);
        
if (x < 100)
{
	Console.WriteLine("Третьей цифры нет");
}
else
{
    while ( x >= 1000)
    {
    	x = x / 10;
    }	
    Console.WriteLine($"{x%10}");
}