// Программа на вход принимает координаты двух точек и находит расстояние между ними в 3D пространстве
Console.WriteLine("Введите координаты точки A");
Console.Write("x = ");
int numberXA = int.Parse(Console.ReadLine());
Console.Write("y = ");
int numberYA = int.Parse(Console.ReadLine());
Console.Write("z = ");
int numberZA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("x = ");
int numberXB = int.Parse(Console.ReadLine());
Console.Write("y = ");
int numberYB = int.Parse(Console.ReadLine());
Console.Write("z = ");
int numberZB = int.Parse(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(numberXB-numberXA, 2)+Math.Pow(numberYB-numberYA, 2)+Math.Pow(numberZB-numberZA, 2));
Console.WriteLine($"Рассточние между точками A и B = {result:f2}");