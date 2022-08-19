// Программа на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA != numberB)
{
    if (numberA > numberB) 
    {
        Console.WriteLine($"Максимальное число = {numberA}");
    }
    else 
    {
        Console.WriteLine($"Максимальное число = {numberB}");
    }
} else Console.WriteLine("Числа равны");
