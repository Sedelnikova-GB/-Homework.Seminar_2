// Пр, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y)

Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine()!);

if (num == 1)
{
    Console.WriteLine("x>0,y>0");
}
else if (num == 2)
{
    Console.WriteLine("x<0,y>0");
}
else if (num == 4)
{
    Console.WriteLine("x>0,y<0");
}
else if (num == 3)
{
    Console.WriteLine("x<0,y<0");
}


// switch(num)
//{
 //   case 1:
   // Console.WriteLine("x>0,y>0");
   // break;
//}