void FindIntersectionPoint(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        Console.Write("Прямые не пересекаются");
    }
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = (k2 * b1 - k1 * b2) / (k2 - k1);
        Console.WriteLine($"Точка пересечения прямых ({x}; {y})");
    }
}

Console.Write("Введите b1: ");
double numberB1 = double.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
double numberK1 = double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double numberB2 = double.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double numberK2 = double.Parse(Console.ReadLine());
FindIntersectionPoint(numberB1, numberK1, numberB2, numberK2);
