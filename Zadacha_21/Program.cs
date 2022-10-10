/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
Console.WriteLine("Введите координату x точки A: ");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y точки A: ");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z точки A: ");
int za = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату x точки B: ");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y точки B: ");
int yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z точки B: ");
int zb = int.Parse(Console.ReadLine()!);
double result = Math.Sqrt(Math.Pow((xb-xa),2) + Math.Pow((yb-ya),2) + Math.Pow((zb-za),2));
Console.WriteLine($"Расстояние между точками A и B равно {result:f2}.");