// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.



int[] points new int[2];

Console.WriteLine("Ввод x && y")
for (int i = 0; i < points.Length; i ++)
points[i = Convert.ToInt32(Console.ReadLine())];

if (points[0] > 0 && points[1] >0)  //points[0] - x , points[1] - y
{
    Console.WriteLine("Это 1-я четверть");
} else if (points[0] < 0 && points[1] >0)
{
    Console.WriteLine("Это 2-я четверть");
}else if (points[0] < 0 && points[1] < 0)
{
    Console.WriteLine("Это 3-я четверть");
}else if (points[0] > 0 && points[1] < 0)
{
    Console.WriteLine("Это 4-я четверть");
}else Console.WriteLine("X &7 Y = 0");