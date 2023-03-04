// Напишите программу, которая принимает
//  на вход координаты двух точек и находит 
//  расстояние между ними в 2D плоскости.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


Double x1, x2, y1, y2, distance;// почему просто дабл? без дабл =  и  почему не стоит запятая после дабл

Console.WriteLine("Расстояние между двумя точками на плоскости");
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





distance = Math.Sqrt(Math.Pow(x2 -x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("Расстояние между двумя точками на плоскости равно: " + Math.Round(distance, 2));