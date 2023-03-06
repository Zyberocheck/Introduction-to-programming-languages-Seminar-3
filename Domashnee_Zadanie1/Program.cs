// Задача 21
// // Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Double x1, x2, y1, y2, z1, z2, distance;

Console.WriteLine("Расстояние между двумя точками на плоскости: ");
Console.WriteLine("Введите координаты точки a: ");

Console.Write("Введите координаты точки x1: ");
x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты точки y1: ");
y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки b: ");

Console.Write("Введите координаты точки x2: ");
x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты точки y2: ");
y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки c: ");

Console.Write("Введите координаты точки z1: ");
z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты точки z2: ");
z2 = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt(Math.Pow(x2 -x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine("Расстояние между тремя точками на плоскости равно: " + Math.Round(distance, 2));

