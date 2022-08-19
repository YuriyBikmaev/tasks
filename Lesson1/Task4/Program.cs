// Программа принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberС = int.Parse(Console.ReadLine());
if ((numberA != numberB) || (numberA != numberС))
{
    if ((numberA > numberB) && (numberA > numberС)) 
    {
        Console.WriteLine($"Максимальное число = {numberA}");
    }
    else if (numberB > numberС)
    {
        Console.WriteLine($"Максимальное число = {numberB}");
    }
    else 
    {
        Console.WriteLine($"Максимальное число = {numberС}");
    }
} else Console.WriteLine("Числа равны");
